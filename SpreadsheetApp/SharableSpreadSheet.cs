using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Text;
    using System.Threading.Tasks;

    class SharableSpreadSheet
    {
        private List<List<string>> spreadSheet;
        private int nRows = 0, nColumns = 0;
        private int nUsers = 0;
        private ReaderWriterLockSlim readerWriter;
        private SemaphoreSlim searcherSemaphore;
        private bool limitUsers = false;

        public SharableSpreadSheet(int nRows, int nCols, int nUsers = -1)
        {
            // nUsers used for setConcurrentSearchLimit, -1 mean no limit.
            // construct a nRows*nCols spreadsheet

            this.nRows = nRows;
            this.nColumns = nCols;
            this.nUsers = nUsers;
            this.spreadSheet = new List<List<string>>();
            this.readerWriter = new ReaderWriterLockSlim();

            if (nRows < 0 || nCols < 0) throw new ArgumentOutOfRangeException("ArgumentException : Invalid dimensions");
            initSpreadSheet();
            setConcurrentSearchLimit(nUsers);
        }


        public String getCell(int row, int col)
        {
            // return the string at [row,col]
            readerWriter.EnterReadLock();
            try
            {
                checkPosition(row, col);
                return spreadSheet[row][col];
            }
            finally
            {
                readerWriter.ExitReadLock();
            }
        }

        public void setCell(int row, int col, String str)
        {
            // set the string at [row,col]

            readerWriter.EnterUpgradeableReadLock();
            try
            {
                checkPosition(row, col);
                if (str == null) throw new ArgumentException("ArgumentException : str is null");

                // If the arguments are valid lock the file and write into it
                readerWriter.EnterWriteLock();
                try
                {
                    spreadSheet[row][col] = str;
                }
                finally
                {
                    readerWriter.ExitWriteLock();
                }

            }
            finally
            {
                readerWriter.ExitUpgradeableReadLock();
            }


        }

        public Tuple<int, int> searchString(String str)
        {
            // return first cell indexes that contains the string (search from first row to the last row)
            if (limitUsers)
                searcherSemaphore.Wait();
            readerWriter.EnterReadLock();
            try
            {
                if (str == null) throw new ArgumentException("ArgumentException : str is null");
                for (int row = 0; row < nRows; row++)
                {
                    for (int col = 0; col < nColumns; col++)
                    {
                        if (spreadSheet[row][col].Equals(str))
                            return new Tuple<int, int>(row, col);
                    }
                }
                throw new Exception("Not found");
            }
            finally
            {
                readerWriter.ExitReadLock();
                if (limitUsers)
                    searcherSemaphore.Release();

            }
        }

        public void exchangeRows(int row1, int row2)
        {
            // exchange the content of row1 and row2
            readerWriter.EnterUpgradeableReadLock();
            try
            {
                checkPosition(row1, 0);
                checkPosition(row2, 0);
                if (row1 == row2) throw new Exception("The two rows' indexes are identical, and cannot be replaced");

                readerWriter.EnterWriteLock();
                try
                {
                    List<string> temp = spreadSheet[row1];
                    spreadSheet[row1] = spreadSheet[row2];
                    spreadSheet[row2] = temp;

                }
                finally
                {
                    readerWriter.ExitWriteLock();
                }

            }
            finally
            {
                readerWriter.ExitUpgradeableReadLock();
            }
        }

        public void exchangeCols(int col1, int col2)
        {
            // exchange the content of col1 and col2
            readerWriter.EnterUpgradeableReadLock();
            try
            {
                checkPosition(0, col1);
                checkPosition(0, col2);
                if (col1 == col2) throw new Exception("The two columns' indexes are identical, and cannot be replaced");

                readerWriter.EnterWriteLock();
                try
                {
                    string tempString;
                    foreach (List<string> row in spreadSheet)
                    {
                        tempString = row[col1];
                        row[col1] = row[col2];
                        row[col2] = tempString;
                    }
                }
                finally
                {
                    readerWriter.ExitWriteLock();
                }
            }
            finally
            {
                readerWriter.ExitUpgradeableReadLock();
            }
        }

        public int searchInRow(int row, String str)
        {
            // perform search in specific row
            if (limitUsers)
                searcherSemaphore.Wait();
            readerWriter.EnterReadLock();
            try
            {
                checkPosition(row, 0);
                if (str == null) throw new ArgumentException("ArgumentException : str is null");

                int colIndex = spreadSheet[row].IndexOf(str);

                if (colIndex < 0)
                    throw new Exception("Not found");

                return colIndex;
            }
            finally
            {
                readerWriter.ExitReadLock();
                if (limitUsers)
                    searcherSemaphore.Release();
            }
        }

        public int searchInCol(int col, String str)
        {
            if (limitUsers)
                searcherSemaphore.Wait();
            readerWriter.EnterReadLock();
            try
            {
                checkPosition(0, col);
                if (str == null) throw new ArgumentException("ArgumentException : str is null");

                for (int row = 0; row < nRows; row++)
                {
                    if (spreadSheet[row][col].Equals(str))
                        return row;
                }

                throw new Exception("Not found");
            }
            finally
            {
                readerWriter.ExitReadLock();
                if (limitUsers)
                    searcherSemaphore.Release();
            }
        }

        public Tuple<int, int> searchInRange(int col1, int col2, int row1, int row2, String str)
        {
            // perform search within spesific range: [row1:row2,col1:col2] 
            //includes col1,col2,row1,row2
            if (limitUsers)
                searcherSemaphore.Wait();
            readerWriter.EnterReadLock();
            try
            {
                checkPosition(row1, col1);
                checkPosition(row2, col2);
                if (row1 > row2 || col1 > col2) throw new ArgumentException("ArgumentException : invalid range");
                if (str == null) throw new ArgumentException("ArgumentException : str is null");


                for (int i = row1; i <= row2; i++)
                {
                    for (int j = col1; j <= col2; j++)
                    {
                        if (spreadSheet[i][j].Equals(str))
                            return new Tuple<int, int>(i, j);
                    }
                }
                throw new Exception("Not found");
            }
            finally
            {
                readerWriter.ExitReadLock();
                if (limitUsers)
                    searcherSemaphore.Release();
            }

        }

        public void addRow(int row1)
        {
            //add a row after row1
            readerWriter.EnterUpgradeableReadLock();
            try
            {
                checkPosition(row1, 0);
                // If the arguments are valid lock the file and write into it
                readerWriter.EnterWriteLock();
                try
                {
                    List<string> newRow = new List<string>();
                    for (int i = 0; i < nColumns; i++)
                        newRow.Add(string.Empty);

                    spreadSheet.Insert(row1 + 1, newRow);
                    nRows++;
                }

                finally
                {
                    readerWriter.ExitWriteLock();
                }
            }
            finally
            {
                readerWriter.ExitUpgradeableReadLock();
            }
        }

        public void addCol(int col1)
        {
            //add a column after col1
            readerWriter.EnterUpgradeableReadLock();
            try
            {
                checkPosition(0, col1);

                // If the arguments are valid lock the file and write into it
                readerWriter.EnterWriteLock();
                try
                {
                    foreach (List<string> list in spreadSheet)
                    {
                        list.Insert(col1 + 1, string.Empty);
                    }
                    nColumns++;
                }
                finally
                {
                    readerWriter.ExitWriteLock();
                }
            }
            finally
            {
                readerWriter.ExitUpgradeableReadLock();
            }
        }

        public Tuple<int, int>[] findAll(String str, bool caseSensitive)
        {
            // perform search and return all relevant cells according to caseSensitive param
            readerWriter.EnterReadLock();
            try
            {
                if (str == null) throw new ArgumentException("ArgumentException : str is null");

                if (!caseSensitive)
                    str = str.ToLower();

                List<Tuple<int, int>> foundPositions = new List<Tuple<int, int>>();

                for (int i = 0; i < nRows; i++)
                {
                    for (int j = 0; j < nColumns; j++)
                    {
                        if (spreadSheet[i][j].Equals(str))
                            foundPositions.Add(new Tuple<int, int>(i, j));
                    }
                }
                if (foundPositions.Count == 0)
                    throw new Exception("Not found");

                return foundPositions.ToArray();
            }
            finally
            {
                readerWriter.ExitReadLock();
            }
        }

        public void setAll(String oldStr, String newStr, bool caseSensitive)
        {
            // replace all oldStr cells with the newStr str according to caseSensitive param
            readerWriter.EnterWriteLock();
            try
            {
                if (oldStr == null || newStr == null) throw new ArgumentException("ArgumentException : str is null");

                // The search is performed before the EnterWriteLock than it is possible to enter the FindAll function
                Tuple<int, int>[] indexsToSet = this.findAll(oldStr, caseSensitive);
                foreach (Tuple<int, int> item in indexsToSet)
                {
                    spreadSheet[item.Item1][item.Item2] = newStr;
                }
            }
            finally
            {
                readerWriter.ExitWriteLock();
            }
        }

        public Tuple<int, int> getSize()
        {
            // return the size of the spreadsheet in nRows, nCols
            readerWriter.EnterReadLock();
            try
            {
                return new Tuple<int, int>(nRows, nColumns);
            }
            finally
            {
                readerWriter.ExitReadLock();
            }
        }

        public void setConcurrentSearchLimit(int nUsers)
        {
            // this function aims to limit the number of users that can perform the search operations concurrently.
            // The default is no limit. When the function is called, the max number of concurrent search operations is set to nUsers. 
            // In this case additional search operations will wait for existing search to finish.
            // This function is used just in the creation
            if (nUsers > 0)
            {
                this.searcherSemaphore = new SemaphoreSlim(nUsers);
                limitUsers = true;
            }
        }

        public void save(String fileName)
        {
            // save the spreadsheet to a file fileName.
            // you can decide the format you save the data. There are several options.

            readerWriter.EnterReadLock();
            try
            {
                // opens the file for writing
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(nRows);
                    writer.WriteLine(nColumns);

                    foreach (List<string> row in spreadSheet)
                    {
                        string ans = string.Join("|", row.ToList());
                        writer.WriteLine(ans);
                    }
                }
            }
            finally
            {
                readerWriter.ExitReadLock();
            }

        }

        public void load(String fileName)
        {
            // load the spreadsheet from fileName
            // replace the data and size of the current spreadsheet with the loaded data

            readerWriter.EnterWriteLock();
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    nRows = Convert.ToInt32(reader.ReadLine());
                    nColumns = Convert.ToInt32(reader.ReadLine());

                    spreadSheet = new List<List<string>>();

                    initSpreadSheet();
                    string line;
                    int currColIndext = 0;
                    int row = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        List<string> tempList = line.Split('|').ToList();
                        spreadSheet[row] = tempList;
                        row++;
                    }
                }
            }
            finally
            {
                readerWriter.ExitWriteLock();
            }

        }

        // ----------------- Auxiliary functions -----------------
        private void checkPosition(int row, int col)
        {
            if (row < 0 || row >= nRows)
                throw new IndexOutOfRangeException("Row index out of bound");
            if (col < 0 || col >= nColumns)
                throw new IndexOutOfRangeException("Column index out of bound");

        }

        private void initSpreadSheet()
        {
            List<string> newRow;
            for (int i = 0; i < nRows; i++)
            {
                newRow = new List<string>();
                for (int j = 0; j < nColumns; j++)
                    newRow.Add(string.Empty);
                spreadSheet.Add(newRow);
            }
        }



    }
}

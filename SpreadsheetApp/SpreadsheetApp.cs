using SpreadsheetApp.Forms;

namespace SpreadsheetApp
{
    public partial class SpreadsheetApp : Form
    {
        protected Form activeForm;
        private SharableSpreadSheet sharableSpreadSheet;
        protected OpenFileDialog openFileDialog = new OpenFileDialog();

        public static SpreadsheetApp self;
        public string fileName = "";
        public static int nRows;
        public static int nColumns;

        public SpreadsheetApp()
        {
            InitializeComponent();
            customizeDesign();
            sharableSpreadSheet = new SharableSpreadSheet(0, 0);
            fileName = "";
            self = this;
        }

        private void customizeDesign()
        {
            panelLoadSubMenue.Visible = false;
            panelSearchSubMenue.Visible = false;
            panelInsertSubMenue.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelLoadSubMenue.Visible = false)
                panelLoadSubMenue.Visible = true;

            if (panelSearchSubMenue.Visible = false)
                panelSearchSubMenue.Visible = true;

            if (panelInsertSubMenue.Visible = false)
                panelInsertSubMenue.Visible = true;
        }

        private void showSubMenue(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            showSubMenue(panelLoadSubMenue);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileName == "") throw new Exception();
                sharableSpreadSheet.save(fileName);
                MessageBox.Show("The file " + fileName + " has been saved successfully.");
            }
            catch
            {
                MessageBox.Show("Please load a SpreadSheet file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------------------------- Load Functionality ---------------------------
        private void btnOpenFileByName_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLoad(), sender);
            hideSubMenu();
        }

        public void loadFileByName(string fileName)
        {
            sharableSpreadSheet.load(fileName);

            Tuple<int, int> size = sharableSpreadSheet.getSize();
            nRows = size.Item1;
            nColumns = size.Item2;

            for (int col = 0; col < nColumns; col++)
            {
                dataGridView.Columns.Add("colName" + (col), "Column " + (col));

                for (int row = 0; row < nRows; row++)
                {
                    dataGridView.Rows.Add();
                    dataGridView[col, row].Value = sharableSpreadSheet.getCell(row, col);
                }
            }

            this.panelStartLogo.Visible = false;
            this.btnRestart.Visible = true;

        }

        public void loadFileFromPC()
        {
            hideSubMenu();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                sharableSpreadSheet.load(fileName);
                Tuple<int, int> size = sharableSpreadSheet.getSize();
                nRows = size.Item1;
                nColumns = size.Item2;

                for (int col = 0; col < nColumns; col++)
                {
                    dataGridView.Columns.Add("colName" + (col), "Column " + (col));

                    for (int row = 0; row < nRows; row++)
                    {
                        dataGridView.Rows.Add();
                        dataGridView[col, row].Value = sharableSpreadSheet.getCell(row, col);
                    }
                }

            }

            this.panelStartLogo.Visible = false;
            this.btnRestart.Visible = true;
        }

        private void btnLoadFromPC_Click(object sender, EventArgs e)
        {
            loadFileFromPC();
        }

        // --------------------------- Search Functionality ---------------------------
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("Please load a SpreadSheet file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            showSubMenue(panelSearchSubMenue);
        }


        // Search in file
        private void btnSearchInFile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSearchInFile(), sender);
            hideSubMenu();
        }

        public void searchInFile(string str)
        {
            try
            {
                Tuple<int, int> ans = sharableSpreadSheet.searchString(str);
                FormSearchInFile.self.setResult(ans);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchInCol(int col, string str)
        {
            try
            {
                int ans = sharableSpreadSheet.searchInCol(col, str);
                FormSearchInCol.self.setResult(ans);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchInRow(int row, string str)
        {
            try
            {
                int ans = sharableSpreadSheet.searchInRow(row, str);
                FormSearchInRow.self.setResult(ans);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search in row

        private void btnSearchInRow_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSearchInRow(), sender);
            hideSubMenu();
        }


        // Search in col
        private void btnSearchInCol_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSearchInCol(), sender);
            hideSubMenu();
        }


        // --------------------------- Insert Functionality ---------------------------
        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("Please load a SpreadSheet file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            showSubMenue(panelInsertSubMenue);
        }

        // Insert to cell
        private void btnInsertToCell_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInsertToCell(), sender);
            hideSubMenu();
        }

        // Replace string
        private void btnReplaceString_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReplaceString(), sender);
            hideSubMenu();
        }

        public void insertCelll(int row, int col, String str)
        {
            try
            {
                sharableSpreadSheet.setCell(row, col, str);
                sharableSpreadSheet.save(fileName);
                loadFileByName(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restart the sheet after saving the file?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                sharableSpreadSheet.save(fileName);
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
                this.panelStartLogo.Visible = true;
                this.btnRestart.Visible = false;
                MessageBox.Show("The file " + fileName + " has been saved successfully.");
            }
        }
    }
}
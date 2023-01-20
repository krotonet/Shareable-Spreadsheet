using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpreadsheetApp.Forms
{
    public partial class FormInsertToCell : Form
    {
        public FormInsertToCell()
        {
            InitializeComponent();
        }

        private void txtBoxString_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxString.Text == "Enter a string to add")
            {
                txtBoxString.Text = "";
                txtBoxString.ForeColor = Color.Black;
            }
        }

        private void txtBoxCol_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxCol.Text == "Col")
            {
                txtBoxCol.Text = "";
                txtBoxCol.ForeColor = Color.Black;
            }
        }

        private void txtBoxRow_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxRow.Text == "Row")
            {
                txtBoxRow.Text = "";
                txtBoxRow.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str = txtBoxString.Text;
            string row = txtBoxRow.Text;
            string col = txtBoxCol.Text;

            try
            {
                if (str == "Enter a string to add" || str == "")
                {
                    MessageBox.Show("Please enter a string to search firs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (col == "Col" || col == "")
                {
                    MessageBox.Show("Please enter a column to search in firs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (row == "Row" || row == "")
                {
                    MessageBox.Show("Please enter a row to search in firs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SpreadsheetApp.self.insertCelll(int.Parse(row), int.Parse(col), str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}

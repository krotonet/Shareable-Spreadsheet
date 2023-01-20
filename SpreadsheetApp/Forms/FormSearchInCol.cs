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
    public partial class FormSearchInCol : Form
    {
        public static FormSearchInCol self;
        public FormSearchInCol()
        {
            InitializeComponent();
            self = this;
        }

        private void txtBoxString_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxString.Text == "Enter a string to search")
            {
                txtBoxString.Text = "";
                txtBoxString.ForeColor = Color.Black;
            }
        }

        private void txtBoxColIndex_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxColIndex.Text == "Enter a column index to search in")
            {
                txtBoxColIndex.Text = "";
                txtBoxColIndex.ForeColor = Color.Black;
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = txtBoxString.Text;
            string col = txtBoxColIndex.Text;

            try
            {
                if (str == "Enter a string to search" || str == "")
                {
                    MessageBox.Show("Please enter a string to search firs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (col == "Enter a column index to search in" || col == "")
                {
                    MessageBox.Show("Please enter a column to search in firs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lblResult.Text = "";
                SpreadsheetApp.self.searchInCol(int.Parse(col), str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void setResult(int row)
        {
            string ans = "The cell[" + row.ToString() + "," + txtBoxColIndex.Text + "] contain the searched string '" + txtBoxString.Text + "'.";
            MessageBox.Show(ans, "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

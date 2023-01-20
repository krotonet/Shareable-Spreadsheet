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
    public partial class FormSearchInRow : Form
    {
        public static FormSearchInRow self;

        public FormSearchInRow()
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

        private void txtBoxRowIndex_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxRowIndex.Text == "Enter a row index to search in")
            {
                txtBoxRowIndex.Text = "";
                txtBoxRowIndex.ForeColor = Color.Black;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = txtBoxString.Text;
            string row = txtBoxRowIndex.Text;

            try
            {
                if (str == "Enter a string to search" || str == "")
                {
                    MessageBox.Show("Please enter a string to search firs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (row == "Enter a row index to search in" || row == "")
                {
                    MessageBox.Show("Please enter a row to search in firs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SpreadsheetApp.self.searchInRow(int.Parse(row), str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void setResult(int col)
        {
            string ans = "The cell [" + txtBoxRowIndex.Text + "," + col.ToString() + "] contain the searched string '" + txtBoxString.Text + "'.";
            MessageBox.Show(ans, "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

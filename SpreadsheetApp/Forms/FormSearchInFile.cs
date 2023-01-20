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
    public partial class FormSearchInFile : Form
    {
        public static FormSearchInFile self;

        
        public FormSearchInFile()
        {
            InitializeComponent();
            self = this;
        }

        private void txtBoxFileName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxString.Text == "Enter a string to search")
            {
                txtBoxString.Text = "";
                txtBoxString.ForeColor = Color.Black;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = txtBoxString.Text;
            try
            {
                if (str == "Enter a string to search" || str == "")
                {
                    MessageBox.Show("Please enter a string to search firs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SpreadsheetApp.self.searchInFile(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public void setResult(Tuple<int, int> pos)
        {
            string ans = "The cell[" + pos.Item1 + "," + pos.Item2 + "] contain the searched string '" + txtBoxString.Text + "'.";
            MessageBox.Show(ans, "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

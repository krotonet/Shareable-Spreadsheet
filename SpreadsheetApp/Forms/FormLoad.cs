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

    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }


        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            string fileName = txtBoxFileName.Text;

            StreamReader Filereader;
            try
            {
                Filereader = new StreamReader(fileName);
                SpreadsheetApp.self.loadFileByName(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBoxFileName_MouseClick(object sender, MouseEventArgs e) // Clicking on the text box will cause the user instructions to disappear
        {
            if (txtBoxFileName.Text == "Insert file name to open")
            {
                txtBoxFileName.Text = "";
                txtBoxFileName.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

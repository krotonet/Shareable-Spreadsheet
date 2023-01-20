namespace SpreadsheetApp.Forms
{
    partial class FormLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.btnSearchAndLoad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxFileName.Location = new System.Drawing.Point(12, 12);
            this.txtBoxFileName.Multiline = true;
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(396, 23);
            this.txtBoxFileName.TabIndex = 1;
            this.txtBoxFileName.Text = "Insert file name to open";
            this.txtBoxFileName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxFileName_MouseClick);
            // 
            // btnSearchAndLoad
            // 
            this.btnSearchAndLoad.Location = new System.Drawing.Point(414, 12);
            this.btnSearchAndLoad.Name = "btnSearchAndLoad";
            this.btnSearchAndLoad.Size = new System.Drawing.Size(111, 23);
            this.btnSearchAndLoad.TabIndex = 2;
            this.btnSearchAndLoad.Text = "Search and load";
            this.btnSearchAndLoad.UseVisualStyleBackColor = true;
            this.btnSearchAndLoad.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 0);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = global::SpreadsheetApp.Properties.Resources.returning;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(908, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 31);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 81);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearchAndLoad);
            this.Controls.Add(this.txtBoxFileName);
            this.Name = "FormLoad";
            this.Text = "FormLoad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtBoxFileName;
        private Button btnSearchAndLoad;
        private TextBox textBox1;
        private Button button1;
    }
}
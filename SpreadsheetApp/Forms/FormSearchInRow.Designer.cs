namespace SpreadsheetApp.Forms
{
    partial class FormSearchInRow
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
            this.txtBoxRowIndex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxRowIndex
            // 
            this.txtBoxRowIndex.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxRowIndex.Location = new System.Drawing.Point(12, 41);
            this.txtBoxRowIndex.Multiline = true;
            this.txtBoxRowIndex.Name = "txtBoxRowIndex";
            this.txtBoxRowIndex.Size = new System.Drawing.Size(396, 23);
            this.txtBoxRowIndex.TabIndex = 21;
            this.txtBoxRowIndex.Text = "Enter a row index to search in";
            this.txtBoxRowIndex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxRowIndex_MouseClick);
            // 
            // button1
            // 
            this.button1.Image = global::SpreadsheetApp.Properties.Resources.returning;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(908, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 31);
            this.button1.TabIndex = 18;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(414, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxString
            // 
            this.txtBoxString.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxString.Location = new System.Drawing.Point(12, 12);
            this.txtBoxString.Multiline = true;
            this.txtBoxString.Name = "txtBoxString";
            this.txtBoxString.Size = new System.Drawing.Size(396, 23);
            this.txtBoxString.TabIndex = 16;
            this.txtBoxString.Text = "Enter a string to search";
            this.txtBoxString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxString_MouseClick);
            // 
            // FormSearchInRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 81);
            this.Controls.Add(this.txtBoxRowIndex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxString);
            this.Name = "FormSearchInRow";
            this.Text = "FormSearchInRow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxRowIndex;
        private Button button1;
        private Button btnSearch;
        private TextBox txtBoxString;
    }
}
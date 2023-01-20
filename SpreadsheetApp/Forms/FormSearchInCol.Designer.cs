namespace SpreadsheetApp.Forms
{
    partial class FormSearchInCol
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxString = new System.Windows.Forms.TextBox();
            this.txtBoxColIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(78, 80);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 21);
            this.lblResult.TabIndex = 14;
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultTitle.Location = new System.Drawing.Point(12, 79);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(61, 21);
            this.lblResultTitle.TabIndex = 13;
            this.lblResultTitle.Text = "Result:";
            // 
            // button1
            // 
            this.button1.Image = global::SpreadsheetApp.Properties.Resources.returning;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(908, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 31);
            this.button1.TabIndex = 12;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(414, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 23);
            this.btnSearch.TabIndex = 11;
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
            this.txtBoxString.TabIndex = 10;
            this.txtBoxString.Text = "Enter a string to search";
            this.txtBoxString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxString_MouseClick);
            // 
            // txtBoxColIndex
            // 
            this.txtBoxColIndex.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxColIndex.Location = new System.Drawing.Point(12, 41);
            this.txtBoxColIndex.Multiline = true;
            this.txtBoxColIndex.Name = "txtBoxColIndex";
            this.txtBoxColIndex.Size = new System.Drawing.Size(396, 23);
            this.txtBoxColIndex.TabIndex = 15;
            this.txtBoxColIndex.Text = "Enter a column index to search in";
            this.txtBoxColIndex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxColIndex_MouseClick);
            // 
            // FormSearchInCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 81);
            this.Controls.Add(this.txtBoxColIndex);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxString);
            this.Name = "FormSearchInCol";
            this.Text = "FormSearchInCol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResult;
        private Label lblResultTitle;
        private Button button1;
        private Button btnSearch;
        private TextBox txtBoxString;
        private TextBox txtBoxColIndex;
    }
}
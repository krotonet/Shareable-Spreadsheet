namespace SpreadsheetApp.Forms
{
    partial class FormInsertToCell
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
            this.txtBoxRow = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxString = new System.Windows.Forms.TextBox();
            this.txtBoxCol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxRow
            // 
            this.txtBoxRow.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxRow.Location = new System.Drawing.Point(12, 43);
            this.txtBoxRow.Multiline = true;
            this.txtBoxRow.Name = "txtBoxRow";
            this.txtBoxRow.Size = new System.Drawing.Size(181, 23);
            this.txtBoxRow.TabIndex = 19;
            this.txtBoxRow.Text = "Row";
            this.txtBoxRow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxRow_MouseClick);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(414, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxString
            // 
            this.txtBoxString.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxString.Location = new System.Drawing.Point(12, 12);
            this.txtBoxString.Multiline = true;
            this.txtBoxString.Name = "txtBoxString";
            this.txtBoxString.Size = new System.Drawing.Size(396, 23);
            this.txtBoxString.TabIndex = 16;
            this.txtBoxString.Text = "Enter a string to add";
            this.txtBoxString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxString_MouseClick);
            // 
            // txtBoxCol
            // 
            this.txtBoxCol.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxCol.Location = new System.Drawing.Point(230, 43);
            this.txtBoxCol.Multiline = true;
            this.txtBoxCol.Name = "txtBoxCol";
            this.txtBoxCol.Size = new System.Drawing.Size(178, 23);
            this.txtBoxCol.TabIndex = 20;
            this.txtBoxCol.Text = "Col";
            this.txtBoxCol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxCol_MouseClick);
            // 
            // FormInsertToCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 81);
            this.Controls.Add(this.txtBoxCol);
            this.Controls.Add(this.txtBoxRow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxString);
            this.Name = "FormInsertToCell";
            this.Text = "FormInsertToCell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxRow;
        private Button button1;
        private Button btnAdd;
        private TextBox txtBoxString;
        private TextBox txtBoxCol;
    }
}
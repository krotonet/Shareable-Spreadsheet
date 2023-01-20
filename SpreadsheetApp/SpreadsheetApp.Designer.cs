namespace SpreadsheetApp
{
    partial class SpreadsheetApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadsheetApp));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelInsertSubMenue = new System.Windows.Forms.Panel();
            this.btnReplaceString = new System.Windows.Forms.Button();
            this.btnInsertToCell = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panelSearchSubMenue = new System.Windows.Forms.Panel();
            this.btnSearchInCol = new System.Windows.Forms.Button();
            this.btnSearchInRow = new System.Windows.Forms.Button();
            this.btnSearchInFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelLoadSubMenue = new System.Windows.Forms.Panel();
            this.btnOpenFileByName = new System.Windows.Forms.Button();
            this.btnLoadFromPC = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStartLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelInsertSubMenue.SuspendLayout();
            this.panelSearchSubMenue.SuspendLayout();
            this.panelLoadSubMenue.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelStartLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelInsertSubMenue);
            this.panelMenu.Controls.Add(this.btnInsert);
            this.panelMenu.Controls.Add(this.panelSearchSubMenue);
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.panelLoadSubMenue);
            this.panelMenu.Controls.Add(this.btnSave);
            this.panelMenu.Controls.Add(this.btnLoad);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 669);
            this.panelMenu.TabIndex = 1;
            // 
            // panelInsertSubMenue
            // 
            this.panelInsertSubMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.panelInsertSubMenue.Controls.Add(this.btnReplaceString);
            this.panelInsertSubMenue.Controls.Add(this.btnInsertToCell);
            this.panelInsertSubMenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInsertSubMenue.Location = new System.Drawing.Point(0, 572);
            this.panelInsertSubMenue.Name = "panelInsertSubMenue";
            this.panelInsertSubMenue.Size = new System.Drawing.Size(220, 129);
            this.panelInsertSubMenue.TabIndex = 12;
            // 
            // btnReplaceString
            // 
            this.btnReplaceString.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReplaceString.FlatAppearance.BorderSize = 0;
            this.btnReplaceString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReplaceString.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReplaceString.Location = new System.Drawing.Point(0, 60);
            this.btnReplaceString.Name = "btnReplaceString";
            this.btnReplaceString.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReplaceString.Size = new System.Drawing.Size(220, 64);
            this.btnReplaceString.TabIndex = 10;
            this.btnReplaceString.Text = "Replace a string";
            this.btnReplaceString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplaceString.UseCompatibleTextRendering = true;
            this.btnReplaceString.UseVisualStyleBackColor = true;
            this.btnReplaceString.Click += new System.EventHandler(this.btnReplaceString_Click);
            // 
            // btnInsertToCell
            // 
            this.btnInsertToCell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertToCell.FlatAppearance.BorderSize = 0;
            this.btnInsertToCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertToCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertToCell.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsertToCell.Location = new System.Drawing.Point(0, 0);
            this.btnInsertToCell.Name = "btnInsertToCell";
            this.btnInsertToCell.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInsertToCell.Size = new System.Drawing.Size(220, 60);
            this.btnInsertToCell.TabIndex = 9;
            this.btnInsertToCell.Text = "Insert to cell";
            this.btnInsertToCell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertToCell.UseCompatibleTextRendering = true;
            this.btnInsertToCell.UseVisualStyleBackColor = true;
            this.btnInsertToCell.Click += new System.EventHandler(this.btnInsertToCell_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsert.Image = global::SpreadsheetApp.Properties.Resources.edit;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(0, 512);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(220, 60);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseCompatibleTextRendering = true;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // panelSearchSubMenue
            // 
            this.panelSearchSubMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.panelSearchSubMenue.Controls.Add(this.btnSearchInCol);
            this.panelSearchSubMenue.Controls.Add(this.btnSearchInRow);
            this.panelSearchSubMenue.Controls.Add(this.btnSearchInFile);
            this.panelSearchSubMenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchSubMenue.Location = new System.Drawing.Point(0, 324);
            this.panelSearchSubMenue.Name = "panelSearchSubMenue";
            this.panelSearchSubMenue.Size = new System.Drawing.Size(220, 188);
            this.panelSearchSubMenue.TabIndex = 10;
            // 
            // btnSearchInCol
            // 
            this.btnSearchInCol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchInCol.FlatAppearance.BorderSize = 0;
            this.btnSearchInCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchInCol.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchInCol.Location = new System.Drawing.Point(0, 124);
            this.btnSearchInCol.Name = "btnSearchInCol";
            this.btnSearchInCol.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearchInCol.Size = new System.Drawing.Size(220, 64);
            this.btnSearchInCol.TabIndex = 11;
            this.btnSearchInCol.Text = "Search in column";
            this.btnSearchInCol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchInCol.UseCompatibleTextRendering = true;
            this.btnSearchInCol.UseVisualStyleBackColor = true;
            this.btnSearchInCol.Click += new System.EventHandler(this.btnSearchInCol_Click);
            // 
            // btnSearchInRow
            // 
            this.btnSearchInRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchInRow.FlatAppearance.BorderSize = 0;
            this.btnSearchInRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchInRow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchInRow.Location = new System.Drawing.Point(0, 60);
            this.btnSearchInRow.Name = "btnSearchInRow";
            this.btnSearchInRow.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearchInRow.Size = new System.Drawing.Size(220, 64);
            this.btnSearchInRow.TabIndex = 10;
            this.btnSearchInRow.Text = "Search in row";
            this.btnSearchInRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchInRow.UseCompatibleTextRendering = true;
            this.btnSearchInRow.UseVisualStyleBackColor = true;
            this.btnSearchInRow.Click += new System.EventHandler(this.btnSearchInRow_Click);
            // 
            // btnSearchInFile
            // 
            this.btnSearchInFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchInFile.FlatAppearance.BorderSize = 0;
            this.btnSearchInFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchInFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchInFile.Location = new System.Drawing.Point(0, 0);
            this.btnSearchInFile.Name = "btnSearchInFile";
            this.btnSearchInFile.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearchInFile.Size = new System.Drawing.Size(220, 60);
            this.btnSearchInFile.TabIndex = 9;
            this.btnSearchInFile.Text = "Search in file";
            this.btnSearchInFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchInFile.UseCompatibleTextRendering = true;
            this.btnSearchInFile.UseVisualStyleBackColor = true;
            this.btnSearchInFile.Click += new System.EventHandler(this.btnSearchInFile_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Image = global::SpreadsheetApp.Properties.Resources.search__2_;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 264);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 60);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseCompatibleTextRendering = true;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // panelLoadSubMenue
            // 
            this.panelLoadSubMenue.AutoScroll = true;
            this.panelLoadSubMenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.panelLoadSubMenue.Controls.Add(this.btnOpenFileByName);
            this.panelLoadSubMenue.Controls.Add(this.btnLoadFromPC);
            this.panelLoadSubMenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoadSubMenue.Location = new System.Drawing.Point(0, 140);
            this.panelLoadSubMenue.Name = "panelLoadSubMenue";
            this.panelLoadSubMenue.Size = new System.Drawing.Size(220, 124);
            this.panelLoadSubMenue.TabIndex = 8;
            // 
            // btnOpenFileByName
            // 
            this.btnOpenFileByName.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFileByName.FlatAppearance.BorderSize = 0;
            this.btnOpenFileByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFileByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFileByName.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFileByName.Location = new System.Drawing.Point(0, 60);
            this.btnOpenFileByName.Name = "btnOpenFileByName";
            this.btnOpenFileByName.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnOpenFileByName.Size = new System.Drawing.Size(220, 64);
            this.btnOpenFileByName.TabIndex = 10;
            this.btnOpenFileByName.Text = "Load by file name";
            this.btnOpenFileByName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFileByName.UseCompatibleTextRendering = true;
            this.btnOpenFileByName.UseVisualStyleBackColor = true;
            this.btnOpenFileByName.Click += new System.EventHandler(this.btnOpenFileByName_Click);
            // 
            // btnLoadFromPC
            // 
            this.btnLoadFromPC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadFromPC.FlatAppearance.BorderSize = 0;
            this.btnLoadFromPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFromPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadFromPC.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoadFromPC.Location = new System.Drawing.Point(0, 0);
            this.btnLoadFromPC.Name = "btnLoadFromPC";
            this.btnLoadFromPC.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLoadFromPC.Size = new System.Drawing.Size(220, 60);
            this.btnLoadFromPC.TabIndex = 9;
            this.btnLoadFromPC.Text = "Load from PC";
            this.btnLoadFromPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadFromPC.UseCompatibleTextRendering = true;
            this.btnLoadFromPC.UseVisualStyleBackColor = true;
            this.btnLoadFromPC.Click += new System.EventHandler(this.btnLoadFromPC_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Image = global::SpreadsheetApp.Properties.Resources.folder;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(0, 609);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 60);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save file";
            this.btnSave.UseCompatibleTextRendering = true;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoad.Image = global::SpreadsheetApp.Properties.Resources.bar;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(0, 80);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(220, 60);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load file";
            this.btnLoad.UseCompatibleTextRendering = true;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.panelLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelLogo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spreadsheet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SpreadsheetApp.Properties.Resources.management__7_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 80);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitleBar.Controls.Add(this.btnRestart);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1005, 80);
            this.panelTitleBar.TabIndex = 4;
            // 
            // btnRestart
            // 
            this.btnRestart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRestart.Image = global::SpreadsheetApp.Properties.Resources.folder2;
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestart.Location = new System.Drawing.Point(922, 0);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(83, 80);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestart.UseCompatibleTextRendering = true;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelStartLogo);
            this.panel1.Controls.Add(this.panelChildForm);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(220, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 589);
            this.panel1.TabIndex = 6;
            // 
            // panelStartLogo
            // 
            this.panelStartLogo.Controls.Add(this.label3);
            this.panelStartLogo.Controls.Add(this.label2);
            this.panelStartLogo.Controls.Add(this.pictureBox2);
            this.panelStartLogo.Location = new System.Drawing.Point(217, 223);
            this.panelStartLogo.Name = "panelStartLogo";
            this.panelStartLogo.Size = new System.Drawing.Size(545, 120);
            this.panelStartLogo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(209)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(119, 81);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(180, 0, 0, 8);
            this.label3.Size = new System.Drawing.Size(426, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Collaborate remotely";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.label2.Location = new System.Drawing.Point(119, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(354, 94);
            this.label2.TabIndex = 9;
            this.label2.Text = "Spreadsheet";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::SpreadsheetApp.Properties.Resources.output_onlinepngtools__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 120);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 512);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1005, 77);
            this.panelChildForm.TabIndex = 13;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1005, 512);
            this.dataGridView.TabIndex = 0;
            // 
            // SpreadsheetApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpreadsheetApp";
            this.Text = "Spreadsheet";
            this.panelMenu.ResumeLayout(false);
            this.panelInsertSubMenue.ResumeLayout(false);
            this.panelSearchSubMenue.ResumeLayout(false);
            this.panelLoadSubMenue.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelStartLogo.ResumeLayout(false);
            this.panelStartLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelMenu;
        private Button btnSave;
        private Button btnLoad;
        private Panel panelLogo;
        private Label label1;
        private Panel panelTitleBar;
        private Panel panel1;
        private DataGridView dataGridView;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Button btnSearch;
        private Panel panelLoadSubMenue;
        private Button btnOpenFileByName;
        private Button btnLoadFromPC;
        private Panel panelSearchSubMenue;
        private Button btnSearchInCol;
        private Button btnSearchInRow;
        private Button btnSearchInFile;
        private Panel panelInsertSubMenue;
        private Button btnReplaceString;
        private Button btnInsertToCell;
        private Button btnInsert;
        private Panel panelChildForm;
        private Panel panelStartLogo;
        private Button btnRestart;
    }
}
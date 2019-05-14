namespace WhiteBloodCell
{
    partial class AVform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVform));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.DirMonitor = new System.Windows.Forms.Button();
            this.DirScan = new System.Windows.Forms.Button();
            this.FileScan = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.IconPic = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoContent = new System.Windows.Forms.TextBox();
            this.InfoTitle = new System.Windows.Forms.Label();
            this.ScanBtn = new System.Windows.Forms.Button();
            this.PageTxt = new System.Windows.Forms.Label();
            this.HomeContent = new System.Windows.Forms.RichTextBox();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.PathBtn = new System.Windows.Forms.Button();
            this.PathField = new System.Windows.Forms.TextBox();
            this.PathTxt = new System.Windows.Forms.Label();
            this.SettingsTitle = new System.Windows.Forms.Label();
            this.SettingsBox = new System.Windows.Forms.CheckedListBox();
            this.SidePanel.SuspendLayout();
            this.NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.SidePanel.Controls.Add(this.Exit);
            this.SidePanel.Controls.Add(this.DirMonitor);
            this.SidePanel.Controls.Add(this.DirScan);
            this.SidePanel.Controls.Add(this.FileScan);
            this.SidePanel.Controls.Add(this.Home);
            this.SidePanel.Controls.Add(this.NamePanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 575);
            this.SidePanel.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(0, 502);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(250, 74);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DirMonitor
            // 
            this.DirMonitor.FlatAppearance.BorderSize = 0;
            this.DirMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirMonitor.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirMonitor.Location = new System.Drawing.Point(0, 340);
            this.DirMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DirMonitor.Name = "DirMonitor";
            this.DirMonitor.Size = new System.Drawing.Size(250, 74);
            this.DirMonitor.TabIndex = 4;
            this.DirMonitor.Text = "Monitor";
            this.DirMonitor.UseVisualStyleBackColor = true;
            this.DirMonitor.Click += new System.EventHandler(this.DirMonitor_Click);
            // 
            // DirScan
            // 
            this.DirScan.FlatAppearance.BorderSize = 0;
            this.DirScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirScan.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirScan.Location = new System.Drawing.Point(0, 257);
            this.DirScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DirScan.Name = "DirScan";
            this.DirScan.Size = new System.Drawing.Size(250, 74);
            this.DirScan.TabIndex = 3;
            this.DirScan.Text = "Folder Scan";
            this.DirScan.UseVisualStyleBackColor = true;
            this.DirScan.Click += new System.EventHandler(this.DirScan_Click);
            // 
            // FileScan
            // 
            this.FileScan.FlatAppearance.BorderSize = 0;
            this.FileScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileScan.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileScan.Location = new System.Drawing.Point(0, 174);
            this.FileScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileScan.Name = "FileScan";
            this.FileScan.Size = new System.Drawing.Size(250, 74);
            this.FileScan.TabIndex = 2;
            this.FileScan.Text = "File Scan";
            this.FileScan.UseVisualStyleBackColor = true;
            this.FileScan.Click += new System.EventHandler(this.FileScan_Click);
            // 
            // Home
            // 
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(0, 91);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(250, 74);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.White;
            this.NamePanel.Controls.Add(this.IconPic);
            this.NamePanel.Controls.Add(this.Title);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(250, 83);
            this.NamePanel.TabIndex = 0;
            // 
            // IconPic
            // 
            this.IconPic.Image = ((System.Drawing.Image)(resources.GetObject("IconPic.Image")));
            this.IconPic.Location = new System.Drawing.Point(0, 0);
            this.IconPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IconPic.Name = "IconPic";
            this.IconPic.Size = new System.Drawing.Size(84, 86);
            this.IconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconPic.TabIndex = 8;
            this.IconPic.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Title.Location = new System.Drawing.Point(129, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(116, 51);
            this.Title.TabIndex = 0;
            this.Title.Text = "WBC";
            this.Title.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.InfoPanel.Controls.Add(this.InfoContent);
            this.InfoPanel.Controls.Add(this.InfoTitle);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(250, 423);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(780, 152);
            this.InfoPanel.TabIndex = 3;
            // 
            // InfoContent
            // 
            this.InfoContent.AcceptsReturn = true;
            this.InfoContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.InfoContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoContent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InfoContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoContent.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoContent.HideSelection = false;
            this.InfoContent.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.InfoContent.Location = new System.Drawing.Point(0, 37);
            this.InfoContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoContent.Multiline = true;
            this.InfoContent.Name = "InfoContent";
            this.InfoContent.ReadOnly = true;
            this.InfoContent.Size = new System.Drawing.Size(780, 115);
            this.InfoContent.TabIndex = 1;
            this.InfoContent.Text = resources.GetString("InfoContent.Text");
            this.InfoContent.TextChanged += new System.EventHandler(this.InfoContent_TextChanged);
            // 
            // InfoTitle
            // 
            this.InfoTitle.AutoSize = true;
            this.InfoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.InfoTitle.ForeColor = System.Drawing.Color.White;
            this.InfoTitle.Location = new System.Drawing.Point(0, 0);
            this.InfoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoTitle.Name = "InfoTitle";
            this.InfoTitle.Size = new System.Drawing.Size(163, 37);
            this.InfoTitle.TabIndex = 0;
            this.InfoTitle.Text = "Information";
            // 
            // ScanBtn
            // 
            this.ScanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ScanBtn.FlatAppearance.BorderSize = 2;
            this.ScanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.ScanBtn.ForeColor = System.Drawing.Color.Black;
            this.ScanBtn.Location = new System.Drawing.Point(831, 325);
            this.ScanBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Size = new System.Drawing.Size(182, 74);
            this.ScanBtn.TabIndex = 5;
            this.ScanBtn.Text = "Download";
            this.ScanBtn.UseVisualStyleBackColor = false;
            this.ScanBtn.Visible = false;
            this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // PageTxt
            // 
            this.PageTxt.AutoSize = true;
            this.PageTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTxt.Location = new System.Drawing.Point(250, 0);
            this.PageTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PageTxt.Name = "PageTxt";
            this.PageTxt.Padding = new System.Windows.Forms.Padding(255, 0, 255, 0);
            this.PageTxt.Size = new System.Drawing.Size(692, 42);
            this.PageTxt.TabIndex = 6;
            this.PageTxt.Text = "Welcome!";
            // 
            // HomeContent
            // 
            this.HomeContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.HomeContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HomeContent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HomeContent.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.HomeContent.Location = new System.Drawing.Point(250, 51);
            this.HomeContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeContent.Name = "HomeContent";
            this.HomeContent.Size = new System.Drawing.Size(756, 151);
            this.HomeContent.TabIndex = 8;
            this.HomeContent.Text = "WBC is a simple, easy to use antivirus which specializes in PDF files. WBC offere" +
    "s single file scans, folder and subfolder scans and a real-time monitor for pdf " +
    "viruses.";
            this.HomeContent.TextChanged += new System.EventHandler(this.HomeContent_TextChanged);
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HomePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.HomePanel.Location = new System.Drawing.Point(250, 149);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(782, 5);
            this.HomePanel.TabIndex = 11;
            // 
            // PathBtn
            // 
            this.PathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathBtn.Location = new System.Drawing.Point(894, 251);
            this.PathBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PathBtn.Name = "PathBtn";
            this.PathBtn.Size = new System.Drawing.Size(118, 46);
            this.PathBtn.TabIndex = 4;
            this.PathBtn.Text = "Browse";
            this.PathBtn.UseVisualStyleBackColor = true;
            this.PathBtn.Visible = false;
            this.PathBtn.Click += new System.EventHandler(this.PathBtn_Click);
            // 
            // PathField
            // 
            this.PathField.BackColor = System.Drawing.Color.White;
            this.PathField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathField.Location = new System.Drawing.Point(482, 257);
            this.PathField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PathField.Name = "PathField";
            this.PathField.ReadOnly = true;
            this.PathField.Size = new System.Drawing.Size(402, 33);
            this.PathField.TabIndex = 2;
            this.PathField.Visible = false;
            this.PathField.TextChanged += new System.EventHandler(this.Path_TextChanged);
            // 
            // PathTxt
            // 
            this.PathTxt.AutoSize = true;
            this.PathTxt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTxt.Location = new System.Drawing.Point(260, 262);
            this.PathTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathTxt.Name = "PathTxt";
            this.PathTxt.Size = new System.Drawing.Size(164, 30);
            this.PathTxt.TabIndex = 7;
            this.PathTxt.Text = "Select a folder";
            this.PathTxt.Visible = false;
            this.PathTxt.Click += new System.EventHandler(this.PathTxt_Click);
            // 
            // SettingsTitle
            // 
            this.SettingsTitle.AutoSize = true;
            this.SettingsTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTitle.Location = new System.Drawing.Point(258, 160);
            this.SettingsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SettingsTitle.Name = "SettingsTitle";
            this.SettingsTitle.Padding = new System.Windows.Forms.Padding(255, 0, 255, 0);
            this.SettingsTitle.Size = new System.Drawing.Size(674, 42);
            this.SettingsTitle.TabIndex = 12;
            this.SettingsTitle.Text = "Settings:";
            // 
            // SettingsBox
            // 
            this.SettingsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SettingsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsBox.CheckOnClick = true;
            this.SettingsBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.SettingsBox.FormattingEnabled = true;
            this.SettingsBox.Items.AddRange(new object[] {
            "Remove files without asking me",
            "Target suspicious PDF files",
            "Notify me for all detections"});
            this.SettingsBox.Location = new System.Drawing.Point(250, 243);
            this.SettingsBox.Margin = new System.Windows.Forms.Padding(10);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(780, 180);
            this.SettingsBox.TabIndex = 13;
            // 
            // AVform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1030, 575);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.SettingsTitle);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.HomeContent);
            this.Controls.Add(this.PathTxt);
            this.Controls.Add(this.PageTxt);
            this.Controls.Add(this.ScanBtn);
            this.Controls.Add(this.PathBtn);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.PathField);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AVform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "White Blood Cell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPic)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DirMonitor;
        private System.Windows.Forms.Button DirScan;
        private System.Windows.Forms.Button FileScan;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label InfoTitle;
        private System.Windows.Forms.TextBox InfoContent;
        private System.Windows.Forms.Button ScanBtn;
        private System.Windows.Forms.Label PageTxt;
        private System.Windows.Forms.PictureBox IconPic;
        private System.Windows.Forms.RichTextBox HomeContent;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button PathBtn;
        private System.Windows.Forms.TextBox PathField;
        private System.Windows.Forms.Label PathTxt;
        private System.Windows.Forms.Label SettingsTitle;
        private System.Windows.Forms.CheckedListBox SettingsBox;
    }
}



namespace TrainzTextureTxtCreator
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.cmdSelectFolder = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eFolderPath = new System.Windows.Forms.TextBox();
            this.cmdGO = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCommandAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCommandHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSelectFolder
            // 
            this.cmdSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelectFolder.Location = new System.Drawing.Point(687, 33);
            this.cmdSelectFolder.Name = "cmdSelectFolder";
            this.cmdSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectFolder.TabIndex = 1;
            this.cmdSelectFolder.Text = "&Select folder";
            this.cmdSelectFolder.UseVisualStyleBackColor = true;
            this.cmdSelectFolder.Click += new System.EventHandler(this.cmdSelectFolder_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Folder of image files:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the folder of the texture image files and hit Go";
            // 
            // eFolderPath
            // 
            this.eFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eFolderPath.Location = new System.Drawing.Point(179, 35);
            this.eFolderPath.Name = "eFolderPath";
            this.eFolderPath.Size = new System.Drawing.Size(502, 20);
            this.eFolderPath.TabIndex = 0;
            // 
            // cmdGO
            // 
            this.cmdGO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGO.Location = new System.Drawing.Point(18, 62);
            this.cmdGO.Name = "cmdGO";
            this.cmdGO.Size = new System.Drawing.Size(747, 23);
            this.cmdGO.TabIndex = 2;
            this.cmdGO.Text = "&GO";
            this.cmdGO.UseVisualStyleBackColor = true;
            this.cmdGO.Click += new System.EventHandler(this.cmdGO_Click);
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(15, 91);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(747, 277);
            this.lbLog.TabIndex = 3;
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdExit.Location = new System.Drawing.Point(12, 382);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(747, 23);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "&Bye";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // menuMain
            // 
            this.menuMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuMain.BackColor = System.Drawing.SystemColors.Menu;
            this.menuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(729, 6);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(36, 24);
            this.menuMain.TabIndex = 7;
            this.menuMain.TabStop = true;
            this.menuMain.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCommandAbout,
            this.menuCommandHelp});
            this.helpToolStripMenuItem.Image = global::TrainzTextureTxtCreator.Properties.Resources.Help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // menuCommandAbout
            // 
            this.menuCommandAbout.Name = "menuCommandAbout";
            this.menuCommandAbout.Size = new System.Drawing.Size(180, 22);
            this.menuCommandAbout.Text = "&About";
            this.menuCommandAbout.Click += new System.EventHandler(this.menuCommandAbout_Click);
            // 
            // menuCommandHelp
            // 
            this.menuCommandHelp.Name = "menuCommandHelp";
            this.menuCommandHelp.Size = new System.Drawing.Size(180, 22);
            this.menuCommandHelp.Text = "&Help && Updates";
            this.menuCommandHelp.Click += new System.EventHandler(this.menuCommandHelp_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 415);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.cmdGO);
            this.Controls.Add(this.eFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmdSelectFolder);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "fMain";
            this.Text = "Trainz Texture TXT Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSelectFolder;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eFolderPath;
        private System.Windows.Forms.Button cmdGO;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCommandAbout;
        private System.Windows.Forms.ToolStripMenuItem menuCommandHelp;
    }
}


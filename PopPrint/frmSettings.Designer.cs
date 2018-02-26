namespace PopPrint
{
    partial class frmSettings
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
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSysProfile = new System.Windows.Forms.Button();
            this.btnJProfiles = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(252, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemProfileToolStripMenuItem,
            this.jobProfileToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // systemProfileToolStripMenuItem
            // 
            this.systemProfileToolStripMenuItem.Name = "systemProfileToolStripMenuItem";
            this.systemProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.systemProfileToolStripMenuItem.Text = "System Profile";
            this.systemProfileToolStripMenuItem.Click += new System.EventHandler(this.systemProfileToolStripMenuItem_Click);
            // 
            // jobProfileToolStripMenuItem
            // 
            this.jobProfileToolStripMenuItem.Name = "jobProfileToolStripMenuItem";
            this.jobProfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jobProfileToolStripMenuItem.Text = "Job Profile";
            this.jobProfileToolStripMenuItem.Click += new System.EventHandler(this.jobProfileToolStripMenuItem_Click);
            // 
            // btnSysProfile
            // 
            this.btnSysProfile.Location = new System.Drawing.Point(12, 53);
            this.btnSysProfile.Name = "btnSysProfile";
            this.btnSysProfile.Size = new System.Drawing.Size(98, 23);
            this.btnSysProfile.TabIndex = 2;
            this.btnSysProfile.Text = "System Profile";
            this.btnSysProfile.UseVisualStyleBackColor = true;
            this.btnSysProfile.Click += new System.EventHandler(this.btnSysProfile_Click);
            // 
            // btnJProfiles
            // 
            this.btnJProfiles.Location = new System.Drawing.Point(13, 83);
            this.btnJProfiles.Name = "btnJProfiles";
            this.btnJProfiles.Size = new System.Drawing.Size(97, 23);
            this.btnJProfiles.TabIndex = 3;
            this.btnJProfiles.Text = "Job Profiles";
            this.btnJProfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnJProfiles.UseVisualStyleBackColor = true;
            this.btnJProfiles.Click += new System.EventHandler(this.btnJProfiles_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 251);
            this.Controls.Add(this.btnJProfiles);
            this.Controls.Add(this.btnSysProfile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Settings";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobProfileToolStripMenuItem;
        private System.Windows.Forms.Button btnSysProfile;
        private System.Windows.Forms.Button btnJProfiles;
    }
}
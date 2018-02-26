namespace PopPrint
{
    partial class frmJobProfiles
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
            this.dgvJobProfileList = new System.Windows.Forms.DataGridView();
            this.dsJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsMailServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsJobProfiles = new System.Data.DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMailServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMailPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMailSecurity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMailUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMailPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbProfileAction = new System.Windows.Forms.ComboBox();
            this.radDeleteMailYes = new System.Windows.Forms.RadioButton();
            this.radMailDeleteNo = new System.Windows.Forms.RadioButton();
            this.grpDeleteMail = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArchiveLocation = new System.Windows.Forms.Button();
            this.txtArchiveLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radArchiveYes = new System.Windows.Forms.RadioButton();
            this.radArchiveNo = new System.Windows.Forms.RadioButton();
            this.fldArchiveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.printDialogSelect = new System.Windows.Forms.PrintDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cmbPrintList = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTestMailSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobProfileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobProfiles)).BeginInit();
            this.grpDeleteMail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(767, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvJobProfileList
            // 
            this.dgvJobProfileList.AutoGenerateColumns = false;
            this.dgvJobProfileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobProfileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dsJobName,
            this.dsMailServer,
            this.dsAction});
            this.dgvJobProfileList.DataSource = this.dsJobProfiles;
            this.dgvJobProfileList.Location = new System.Drawing.Point(12, 32);
            this.dgvJobProfileList.Name = "dgvJobProfileList";
            this.dgvJobProfileList.Size = new System.Drawing.Size(673, 162);
            this.dgvJobProfileList.TabIndex = 1;
            this.dgvJobProfileList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobProfileList_CellContentClick);
            // 
            // dsJobName
            // 
            this.dsJobName.DataPropertyName = "Name";
            this.dsJobName.HeaderText = "Job Name";
            this.dsJobName.Name = "dsJobName";
            this.dsJobName.Width = 300;
            // 
            // dsMailServer
            // 
            this.dsMailServer.DataPropertyName = "PopServer";
            this.dsMailServer.HeaderText = "Mail Server";
            this.dsMailServer.Name = "dsMailServer";
            this.dsMailServer.Width = 200;
            // 
            // dsAction
            // 
            this.dsAction.DataPropertyName = "PopAction";
            this.dsAction.HeaderText = "Action";
            this.dsAction.Name = "dsAction";
            // 
            // dsJobProfiles
            // 
            this.dsJobProfiles.DataSetName = "dsNameJobProfiles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 215);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mail Server Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server Name / IP :";
            // 
            // txtMailServer
            // 
            this.txtMailServer.Location = new System.Drawing.Point(121, 273);
            this.txtMailServer.Name = "txtMailServer";
            this.txtMailServer.Size = new System.Drawing.Size(114, 20);
            this.txtMailServer.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMailPort
            // 
            this.txtMailPort.Location = new System.Drawing.Point(121, 301);
            this.txtMailPort.Name = "txtMailPort";
            this.txtMailPort.Size = new System.Drawing.Size(55, 20);
            this.txtMailPort.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SSL : ";
            // 
            // cmbMailSecurity
            // 
            this.cmbMailSecurity.FormattingEnabled = true;
            this.cmbMailSecurity.Items.AddRange(new object[] {
            "none",
            "SSL",
            "TLS"});
            this.cmbMailSecurity.Location = new System.Drawing.Point(121, 329);
            this.cmbMailSecurity.Name = "cmbMailSecurity";
            this.cmbMailSecurity.Size = new System.Drawing.Size(121, 21);
            this.cmbMailSecurity.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "User Name :";
            // 
            // txtMailUser
            // 
            this.txtMailUser.Location = new System.Drawing.Point(121, 358);
            this.txtMailUser.Name = "txtMailUser";
            this.txtMailUser.Size = new System.Drawing.Size(100, 20);
            this.txtMailUser.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mail Password :";
            // 
            // txtMailPass
            // 
            this.txtMailPass.Location = new System.Drawing.Point(121, 386);
            this.txtMailPass.Name = "txtMailPass";
            this.txtMailPass.PasswordChar = '*';
            this.txtMailPass.Size = new System.Drawing.Size(100, 20);
            this.txtMailPass.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Action :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(391, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Profile Actions";
            // 
            // cmbProfileAction
            // 
            this.cmbProfileAction.FormattingEnabled = true;
            this.cmbProfileAction.Items.AddRange(new object[] {
            "Print",
            "Save",
            "Forward"});
            this.cmbProfileAction.Location = new System.Drawing.Point(441, 273);
            this.cmbProfileAction.Name = "cmbProfileAction";
            this.cmbProfileAction.Size = new System.Drawing.Size(143, 21);
            this.cmbProfileAction.TabIndex = 17;
            // 
            // radDeleteMailYes
            // 
            this.radDeleteMailYes.AutoSize = true;
            this.radDeleteMailYes.Location = new System.Drawing.Point(117, 0);
            this.radDeleteMailYes.Name = "radDeleteMailYes";
            this.radDeleteMailYes.Size = new System.Drawing.Size(43, 17);
            this.radDeleteMailYes.TabIndex = 19;
            this.radDeleteMailYes.Text = "Yes";
            this.radDeleteMailYes.UseVisualStyleBackColor = true;
            // 
            // radMailDeleteNo
            // 
            this.radMailDeleteNo.AutoSize = true;
            this.radMailDeleteNo.Checked = true;
            this.radMailDeleteNo.Location = new System.Drawing.Point(166, 0);
            this.radMailDeleteNo.Name = "radMailDeleteNo";
            this.radMailDeleteNo.Size = new System.Drawing.Size(39, 17);
            this.radMailDeleteNo.TabIndex = 20;
            this.radMailDeleteNo.TabStop = true;
            this.radMailDeleteNo.Text = "No";
            this.radMailDeleteNo.UseVisualStyleBackColor = true;
            // 
            // grpDeleteMail
            // 
            this.grpDeleteMail.Controls.Add(this.radDeleteMailYes);
            this.grpDeleteMail.Controls.Add(this.radMailDeleteNo);
            this.grpDeleteMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDeleteMail.Location = new System.Drawing.Point(394, 307);
            this.grpDeleteMail.Name = "grpDeleteMail";
            this.grpDeleteMail.Size = new System.Drawing.Size(205, 31);
            this.grpDeleteMail.TabIndex = 21;
            this.grpDeleteMail.TabStop = false;
            this.grpDeleteMail.Text = "Delete Message :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArchiveLocation);
            this.groupBox1.Controls.Add(this.txtArchiveLocation);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.radArchiveYes);
            this.groupBox1.Controls.Add(this.radArchiveNo);
            this.groupBox1.Location = new System.Drawing.Point(394, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 56);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archive Attachment :";
            // 
            // btnArchiveLocation
            // 
            this.btnArchiveLocation.Location = new System.Drawing.Point(284, 29);
            this.btnArchiveLocation.Name = "btnArchiveLocation";
            this.btnArchiveLocation.Size = new System.Drawing.Size(26, 20);
            this.btnArchiveLocation.TabIndex = 23;
            this.btnArchiveLocation.Text = "...";
            this.btnArchiveLocation.UseVisualStyleBackColor = true;
            this.btnArchiveLocation.Click += new System.EventHandler(this.btnArchiveLocation_Click);
            // 
            // txtArchiveLocation
            // 
            this.txtArchiveLocation.Location = new System.Drawing.Point(68, 29);
            this.txtArchiveLocation.Name = "txtArchiveLocation";
            this.txtArchiveLocation.Size = new System.Drawing.Size(219, 20);
            this.txtArchiveLocation.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Location :";
            // 
            // radArchiveYes
            // 
            this.radArchiveYes.AutoSize = true;
            this.radArchiveYes.Checked = true;
            this.radArchiveYes.Location = new System.Drawing.Point(117, 0);
            this.radArchiveYes.Name = "radArchiveYes";
            this.radArchiveYes.Size = new System.Drawing.Size(43, 17);
            this.radArchiveYes.TabIndex = 19;
            this.radArchiveYes.TabStop = true;
            this.radArchiveYes.Text = "Yes";
            this.radArchiveYes.UseVisualStyleBackColor = true;
            // 
            // radArchiveNo
            // 
            this.radArchiveNo.AutoSize = true;
            this.radArchiveNo.Location = new System.Drawing.Point(166, 0);
            this.radArchiveNo.Name = "radArchiveNo";
            this.radArchiveNo.Size = new System.Drawing.Size(39, 17);
            this.radArchiveNo.TabIndex = 20;
            this.radArchiveNo.Text = "No";
            this.radArchiveNo.UseVisualStyleBackColor = true;
            // 
            // fldArchiveLocation
            // 
            this.fldArchiveLocation.RootFolder = System.Environment.SpecialFolder.CommonDocuments;
            // 
            // printDialogSelect
            // 
            this.printDialogSelect.UseEXDialog = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(767, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(767, 400);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cmbPrintList
            // 
            this.cmbPrintList.FormattingEnabled = true;
            this.cmbPrintList.Location = new System.Drawing.Point(394, 429);
            this.cmbPrintList.Name = "cmbPrintList";
            this.cmbPrintList.Size = new System.Drawing.Size(325, 21);
            this.cmbPrintList.TabIndex = 26;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(644, 456);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 27;
            this.btnTest.Text = "Test Print";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(391, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Default Printer";
            // 
            // btnTestMailSettings
            // 
            this.btnTestMailSettings.Location = new System.Drawing.Point(14, 415);
            this.btnTestMailSettings.Name = "btnTestMailSettings";
            this.btnTestMailSettings.Size = new System.Drawing.Size(75, 23);
            this.btnTestMailSettings.TabIndex = 29;
            this.btnTestMailSettings.Text = "Test Mail Settings";
            this.btnTestMailSettings.UseVisualStyleBackColor = true;
            // 
            // frmJobProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 494);
            this.Controls.Add(this.btnTestMailSettings);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.cmbPrintList);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDeleteMail);
            this.Controls.Add(this.cmbProfileAction);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMailPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMailUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMailSecurity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMailPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMailServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJobProfileList);
            this.Controls.Add(this.btnClose);
            this.Name = "frmJobProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Profiles";
            this.Load += new System.EventHandler(this.frmJobProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobProfileList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobProfiles)).EndInit();
            this.grpDeleteMail.ResumeLayout(false);
            this.grpDeleteMail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvJobProfileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMailServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMailPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMailSecurity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMailUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMailPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbProfileAction;
        private System.Windows.Forms.RadioButton radDeleteMailYes;
        private System.Windows.Forms.RadioButton radMailDeleteNo;
        private System.Windows.Forms.GroupBox grpDeleteMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnArchiveLocation;
        private System.Windows.Forms.TextBox txtArchiveLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radArchiveYes;
        private System.Windows.Forms.RadioButton radArchiveNo;
        private System.Windows.Forms.FolderBrowserDialog fldArchiveLocation;
        private System.Windows.Forms.PrintDialog printDialogSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Data.DataSet dsJobProfiles;
        private System.Windows.Forms.ComboBox cmbPrintList;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsMailServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsAction;
        private System.Windows.Forms.Button btnTestMailSettings;
    }
}
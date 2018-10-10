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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobProfiles));
            this.btnClose = new System.Windows.Forms.Button();
            this.cmJobProfile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateDeActivateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsMailbox = new System.Data.DataSet();
            this.fldArchiveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.printDialogSelect = new System.Windows.Forms.PrintDialog();
            this.gbMailboxes = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvMailBoxList = new System.Windows.Forms.DataGridView();
            this.MailServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailBox_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmMailBoxList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMailboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateMailboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMailTo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.pbMailPassword = new System.Windows.Forms.PictureBox();
            this.pbMailUsername = new System.Windows.Forms.PictureBox();
            this.pbMailServerPort = new System.Windows.Forms.PictureBox();
            this.pbMailServer = new System.Windows.Forms.PictureBox();
            this.btnTestMailSettings = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMailPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMailUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMailSecurity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMailPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMailServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.gbFtpDetails = new System.Windows.Forms.GroupBox();
            this.gbPrinterDetails = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.cmbPrintList = new System.Windows.Forms.ComboBox();
            this.pbDefaultPrinter = new System.Windows.Forms.PictureBox();
            this.btnCancelRule = new System.Windows.Forms.Button();
            this.btnNewRule = new System.Windows.Forms.Button();
            this.btnSaveRule = new System.Windows.Forms.Button();
            this.dgvRulesList = new System.Windows.Forms.DataGridView();
            this.RuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmRules = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markInactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFromAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.grpArchiveAttach = new System.Windows.Forms.GroupBox();
            this.pbArchiveLocation = new System.Windows.Forms.PictureBox();
            this.btnArchiveLocation = new System.Windows.Forms.Button();
            this.txtArchiveLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radArchiveYes = new System.Windows.Forms.RadioButton();
            this.radArchiveNo = new System.Windows.Forms.RadioButton();
            this.grpDeleteMail = new System.Windows.Forms.GroupBox();
            this.radDeleteMailYes = new System.Windows.Forms.RadioButton();
            this.radMailDeleteNo = new System.Windows.Forms.RadioButton();
            this.cmbProfileAction = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbInactive = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbFtpBasic = new System.Windows.Forms.TabPage();
            this.bbTestFtp = new System.Windows.Forms.Button();
            this.cbFtpSecure = new System.Windows.Forms.CheckBox();
            this.edFtpPassword = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.edFtpUsername = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.edFtpfolders = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.edFtpPort = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.edFtpServer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAdvancedFtp = new System.Windows.Forms.TabPage();
            this.bbKeyPath = new System.Windows.Forms.Button();
            this.edFingerPrint = new System.Windows.Forms.TextBox();
            this.edKeyPath = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmJobProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMailbox)).BeginInit();
            this.gbMailboxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMailBoxList)).BeginInit();
            this.cmMailBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMailPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMailUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMailServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMailServer)).BeginInit();
            this.gbRules.SuspendLayout();
            this.gbFtpDetails.SuspendLayout();
            this.gbPrinterDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRulesList)).BeginInit();
            this.cmRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            this.grpArchiveAttach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArchiveLocation)).BeginInit();
            this.grpDeleteMail.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbFtpBasic.SuspendLayout();
            this.tbAdvancedFtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CausesValidation = false;
            this.btnClose.Location = new System.Drawing.Point(885, 589);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmJobProfile
            // 
            this.cmJobProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteProfileToolStripMenuItem,
            this.activateDeActivateProfileToolStripMenuItem});
            this.cmJobProfile.Name = "cmJobProfile";
            this.cmJobProfile.Size = new System.Drawing.Size(222, 48);
            this.cmJobProfile.Opening += new System.ComponentModel.CancelEventHandler(this.cmJobProfile_Opening);
            // 
            // deleteProfileToolStripMenuItem
            // 
            this.deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            this.deleteProfileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.deleteProfileToolStripMenuItem.Text = "Delete Profile";
            this.deleteProfileToolStripMenuItem.Click += new System.EventHandler(this.deleteProfileToolStripMenuItem_Click);
            // 
            // activateDeActivateProfileToolStripMenuItem
            // 
            this.activateDeActivateProfileToolStripMenuItem.Name = "activateDeActivateProfileToolStripMenuItem";
            this.activateDeActivateProfileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.activateDeActivateProfileToolStripMenuItem.Text = "Activate/De-Activate Profile";
            // 
            // dsMailbox
            // 
            this.dsMailbox.DataSetName = "dsNameJobProfiles";
            // 
            // fldArchiveLocation
            // 
            this.fldArchiveLocation.RootFolder = System.Environment.SpecialFolder.CommonDocuments;
            // 
            // printDialogSelect
            // 
            this.printDialogSelect.UseEXDialog = true;
            // 
            // gbMailboxes
            // 
            this.gbMailboxes.Controls.Add(this.btnLoad);
            this.gbMailboxes.Controls.Add(this.dgvMailBoxList);
            this.gbMailboxes.Controls.Add(this.label14);
            this.gbMailboxes.Controls.Add(this.txtMailTo);
            this.gbMailboxes.Controls.Add(this.btnCancel);
            this.gbMailboxes.Controls.Add(this.label16);
            this.gbMailboxes.Controls.Add(this.pbMailPassword);
            this.gbMailboxes.Controls.Add(this.pbMailUsername);
            this.gbMailboxes.Controls.Add(this.pbMailServerPort);
            this.gbMailboxes.Controls.Add(this.pbMailServer);
            this.gbMailboxes.Controls.Add(this.btnTestMailSettings);
            this.gbMailboxes.Controls.Add(this.btnNew);
            this.gbMailboxes.Controls.Add(this.btnSave);
            this.gbMailboxes.Controls.Add(this.txtMailPass);
            this.gbMailboxes.Controls.Add(this.label7);
            this.gbMailboxes.Controls.Add(this.txtMailUser);
            this.gbMailboxes.Controls.Add(this.label6);
            this.gbMailboxes.Controls.Add(this.cmbMailSecurity);
            this.gbMailboxes.Controls.Add(this.label5);
            this.gbMailboxes.Controls.Add(this.txtMailPort);
            this.gbMailboxes.Controls.Add(this.label4);
            this.gbMailboxes.Controls.Add(this.txtMailServer);
            this.gbMailboxes.Controls.Add(this.label3);
            this.gbMailboxes.Controls.Add(this.label2);
            this.gbMailboxes.Location = new System.Drawing.Point(5, 3);
            this.gbMailboxes.Name = "gbMailboxes";
            this.gbMailboxes.Size = new System.Drawing.Size(470, 583);
            this.gbMailboxes.TabIndex = 58;
            this.gbMailboxes.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(390, 139);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 78;
            this.btnLoad.Text = "Re-Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvMailBoxList
            // 
            this.dgvMailBoxList.AllowUserToAddRows = false;
            this.dgvMailBoxList.AllowUserToDeleteRows = false;
            this.dgvMailBoxList.AutoGenerateColumns = false;
            this.dgvMailBoxList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMailBoxList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MailServer,
            this.EmailTo,
            this.MailBox_Id});
            this.dgvMailBoxList.ContextMenuStrip = this.cmMailBoxList;
            this.dgvMailBoxList.DataSource = this.dsMailbox;
            this.dgvMailBoxList.Location = new System.Drawing.Point(18, 56);
            this.dgvMailBoxList.MultiSelect = false;
            this.dgvMailBoxList.Name = "dgvMailBoxList";
            this.dgvMailBoxList.ReadOnly = true;
            this.dgvMailBoxList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMailBoxList.Size = new System.Drawing.Size(366, 106);
            this.dgvMailBoxList.TabIndex = 77;
            this.dgvMailBoxList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobProfileList_CellDoubleClick);
            this.dgvMailBoxList.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvMailBoxList_RowStateChanged);
            this.dgvMailBoxList.SelectionChanged += new System.EventHandler(this.dgvMailBoxList_SelectionChanged);
            // 
            // MailServer
            // 
            this.MailServer.DataPropertyName = "PopServer";
            this.MailServer.HeaderText = "Mail Server";
            this.MailServer.MinimumWidth = 10;
            this.MailServer.Name = "MailServer";
            this.MailServer.ReadOnly = true;
            this.MailServer.Width = 150;
            // 
            // EmailTo
            // 
            this.EmailTo.DataPropertyName = "AddressTo";
            this.EmailTo.HeaderText = "Email To";
            this.EmailTo.MinimumWidth = 15;
            this.EmailTo.Name = "EmailTo";
            this.EmailTo.ReadOnly = true;
            this.EmailTo.Width = 150;
            // 
            // MailBox_Id
            // 
            this.MailBox_Id.DataPropertyName = "Mailbox_Id";
            this.MailBox_Id.HeaderText = "Mailbox_Id";
            this.MailBox_Id.Name = "MailBox_Id";
            this.MailBox_Id.ReadOnly = true;
            this.MailBox_Id.Visible = false;
            // 
            // cmMailBoxList
            // 
            this.cmMailBoxList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMailboxToolStripMenuItem,
            this.duplicateMailboxToolStripMenuItem});
            this.cmMailBoxList.Name = "cmMailBoxList";
            this.cmMailBoxList.Size = new System.Drawing.Size(170, 48);
            this.cmMailBoxList.Opening += new System.ComponentModel.CancelEventHandler(this.cmMailBoxList_Opening);
            // 
            // deleteMailboxToolStripMenuItem
            // 
            this.deleteMailboxToolStripMenuItem.Name = "deleteMailboxToolStripMenuItem";
            this.deleteMailboxToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deleteMailboxToolStripMenuItem.Text = "Delete Mailbox";
            this.deleteMailboxToolStripMenuItem.Click += new System.EventHandler(this.deleteMailboxToolStripMenuItem_Click);
            // 
            // duplicateMailboxToolStripMenuItem
            // 
            this.duplicateMailboxToolStripMenuItem.Name = "duplicateMailboxToolStripMenuItem";
            this.duplicateMailboxToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.duplicateMailboxToolStripMenuItem.Text = "Duplicate Mailbox";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Email To : ";
            // 
            // txtMailTo
            // 
            this.txtMailTo.Location = new System.Drawing.Point(125, 200);
            this.txtMailTo.Name = "txtMailTo";
            this.txtMailTo.Size = new System.Drawing.Size(200, 20);
            this.txtMailTo.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(390, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 73;
            this.label16.Text = "Current Mailboxes";
            // 
            // pbMailPassword
            // 
            this.pbMailPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbMailPassword.Image")));
            this.pbMailPassword.Location = new System.Drawing.Point(231, 303);
            this.pbMailPassword.Name = "pbMailPassword";
            this.pbMailPassword.Size = new System.Drawing.Size(18, 15);
            this.pbMailPassword.TabIndex = 72;
            this.pbMailPassword.TabStop = false;
            this.pbMailPassword.Visible = false;
            // 
            // pbMailUsername
            // 
            this.pbMailUsername.Image = ((System.Drawing.Image)(resources.GetObject("pbMailUsername.Image")));
            this.pbMailUsername.Location = new System.Drawing.Point(231, 278);
            this.pbMailUsername.Name = "pbMailUsername";
            this.pbMailUsername.Size = new System.Drawing.Size(18, 15);
            this.pbMailUsername.TabIndex = 71;
            this.pbMailUsername.TabStop = false;
            this.pbMailUsername.Visible = false;
            // 
            // pbMailServerPort
            // 
            this.pbMailServerPort.Image = ((System.Drawing.Image)(resources.GetObject("pbMailServerPort.Image")));
            this.pbMailServerPort.Location = new System.Drawing.Point(166, 253);
            this.pbMailServerPort.Name = "pbMailServerPort";
            this.pbMailServerPort.Size = new System.Drawing.Size(18, 15);
            this.pbMailServerPort.TabIndex = 70;
            this.pbMailServerPort.TabStop = false;
            this.pbMailServerPort.Visible = false;
            // 
            // pbMailServer
            // 
            this.pbMailServer.Image = ((System.Drawing.Image)(resources.GetObject("pbMailServer.Image")));
            this.pbMailServer.Location = new System.Drawing.Point(381, 230);
            this.pbMailServer.Name = "pbMailServer";
            this.pbMailServer.Size = new System.Drawing.Size(18, 15);
            this.pbMailServer.TabIndex = 69;
            this.pbMailServer.TabStop = false;
            this.pbMailServer.Visible = false;
            // 
            // btnTestMailSettings
            // 
            this.btnTestMailSettings.Location = new System.Drawing.Point(255, 300);
            this.btnTestMailSettings.Name = "btnTestMailSettings";
            this.btnTestMailSettings.Size = new System.Drawing.Size(75, 23);
            this.btnTestMailSettings.TabIndex = 7;
            this.btnTestMailSettings.Text = "Test";
            this.btnTestMailSettings.UseVisualStyleBackColor = true;
            this.btnTestMailSettings.Click += new System.EventHandler(this.btnTestMailSettings_Click);
            // 
            // btnNew
            // 
            this.btnNew.CausesValidation = false;
            this.btnNew.Location = new System.Drawing.Point(390, 51);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 67;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMailPass
            // 
            this.txtMailPass.Location = new System.Drawing.Point(125, 300);
            this.txtMailPass.Name = "txtMailPass";
            this.txtMailPass.PasswordChar = '*';
            this.txtMailPass.Size = new System.Drawing.Size(100, 20);
            this.txtMailPass.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Mail Password :";
            // 
            // txtMailUser
            // 
            this.txtMailUser.Location = new System.Drawing.Point(125, 276);
            this.txtMailUser.Name = "txtMailUser";
            this.txtMailUser.Size = new System.Drawing.Size(100, 20);
            this.txtMailUser.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "User Name :";
            // 
            // cmbMailSecurity
            // 
            this.cmbMailSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMailSecurity.FormattingEnabled = true;
            this.cmbMailSecurity.Items.AddRange(new object[] {
            "none",
            "SSL",
            "TLS"});
            this.cmbMailSecurity.Location = new System.Drawing.Point(243, 251);
            this.cmbMailSecurity.Name = "cmbMailSecurity";
            this.cmbMailSecurity.Size = new System.Drawing.Size(121, 21);
            this.cmbMailSecurity.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "SSL : ";
            // 
            // txtMailPort
            // 
            this.txtMailPort.Location = new System.Drawing.Point(125, 252);
            this.txtMailPort.Name = "txtMailPort";
            this.txtMailPort.Size = new System.Drawing.Size(35, 20);
            this.txtMailPort.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Port :";
            // 
            // txtMailServer
            // 
            this.txtMailServer.Location = new System.Drawing.Point(125, 226);
            this.txtMailServer.Name = "txtMailServer";
            this.txtMailServer.Size = new System.Drawing.Size(250, 20);
            this.txtMailServer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Server Name / IP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mail Server Details";
            // 
            // gbRules
            // 
            this.gbRules.Controls.Add(this.rbInactive);
            this.gbRules.Controls.Add(this.rbActive);
            this.gbRules.Controls.Add(this.rbAll);
            this.gbRules.Controls.Add(this.label17);
            this.gbRules.Controls.Add(this.gbFtpDetails);
            this.gbRules.Controls.Add(this.gbPrinterDetails);
            this.gbRules.Controls.Add(this.btnCancelRule);
            this.gbRules.Controls.Add(this.btnNewRule);
            this.gbRules.Controls.Add(this.btnSaveRule);
            this.gbRules.Controls.Add(this.dgvRulesList);
            this.gbRules.Controls.Add(this.cbIsActive);
            this.gbRules.Controls.Add(this.txtSubject);
            this.gbRules.Controls.Add(this.label15);
            this.gbRules.Controls.Add(this.txtFromAddress);
            this.gbRules.Controls.Add(this.label13);
            this.gbRules.Controls.Add(this.label12);
            this.gbRules.Controls.Add(this.pbName);
            this.gbRules.Controls.Add(this.grpArchiveAttach);
            this.gbRules.Controls.Add(this.grpDeleteMail);
            this.gbRules.Controls.Add(this.cmbProfileAction);
            this.gbRules.Controls.Add(this.label9);
            this.gbRules.Controls.Add(this.label8);
            this.gbRules.Controls.Add(this.txtName);
            this.gbRules.Controls.Add(this.label1);
            this.gbRules.Location = new System.Drawing.Point(476, 3);
            this.gbRules.Name = "gbRules";
            this.gbRules.Size = new System.Drawing.Size(486, 583);
            this.gbRules.TabIndex = 79;
            this.gbRules.TabStop = false;
            // 
            // gbFtpDetails
            // 
            this.gbFtpDetails.Controls.Add(this.tabControl1);
            this.gbFtpDetails.Location = new System.Drawing.Point(6, 322);
            this.gbFtpDetails.Name = "gbFtpDetails";
            this.gbFtpDetails.Size = new System.Drawing.Size(475, 168);
            this.gbFtpDetails.TabIndex = 84;
            this.gbFtpDetails.TabStop = false;
            this.gbFtpDetails.Text = "FTP Details";
            this.gbFtpDetails.Visible = false;
            // 
            // gbPrinterDetails
            // 
            this.gbPrinterDetails.Controls.Add(this.btnTest);
            this.gbPrinterDetails.Controls.Add(this.cmbPrintList);
            this.gbPrinterDetails.Controls.Add(this.pbDefaultPrinter);
            this.gbPrinterDetails.Location = new System.Drawing.Point(22, 365);
            this.gbPrinterDetails.Name = "gbPrinterDetails";
            this.gbPrinterDetails.Size = new System.Drawing.Size(458, 114);
            this.gbPrinterDetails.TabIndex = 83;
            this.gbPrinterDetails.TabStop = false;
            this.gbPrinterDetails.Text = "Printer Selection";
            this.gbPrinterDetails.Visible = false;
            // 
            // btnTest
            // 
            this.btnTest.CausesValidation = false;
            this.btnTest.Location = new System.Drawing.Point(370, 26);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 66;
            this.btnTest.Text = "Test Print";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cmbPrintList
            // 
            this.cmbPrintList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrintList.FormattingEnabled = true;
            this.cmbPrintList.Location = new System.Drawing.Point(15, 28);
            this.cmbPrintList.Name = "cmbPrintList";
            this.cmbPrintList.Size = new System.Drawing.Size(325, 21);
            this.cmbPrintList.TabIndex = 65;
            // 
            // pbDefaultPrinter
            // 
            this.pbDefaultPrinter.Image = ((System.Drawing.Image)(resources.GetObject("pbDefaultPrinter.Image")));
            this.pbDefaultPrinter.Location = new System.Drawing.Point(346, 28);
            this.pbDefaultPrinter.Name = "pbDefaultPrinter";
            this.pbDefaultPrinter.Size = new System.Drawing.Size(18, 15);
            this.pbDefaultPrinter.TabIndex = 71;
            this.pbDefaultPrinter.TabStop = false;
            this.pbDefaultPrinter.Visible = false;
            // 
            // btnCancelRule
            // 
            this.btnCancelRule.Location = new System.Drawing.Point(405, 114);
            this.btnCancelRule.Name = "btnCancelRule";
            this.btnCancelRule.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRule.TabIndex = 82;
            this.btnCancelRule.Text = "Cancel";
            this.btnCancelRule.UseVisualStyleBackColor = true;
            this.btnCancelRule.Click += new System.EventHandler(this.btnCancelRule_Click_1);
            // 
            // btnNewRule
            // 
            this.btnNewRule.CausesValidation = false;
            this.btnNewRule.Location = new System.Drawing.Point(405, 54);
            this.btnNewRule.Name = "btnNewRule";
            this.btnNewRule.Size = new System.Drawing.Size(75, 23);
            this.btnNewRule.TabIndex = 80;
            this.btnNewRule.Text = "New";
            this.btnNewRule.UseVisualStyleBackColor = true;
            this.btnNewRule.Click += new System.EventHandler(this.btnNewRule_Click);
            // 
            // btnSaveRule
            // 
            this.btnSaveRule.Location = new System.Drawing.Point(405, 85);
            this.btnSaveRule.Name = "btnSaveRule";
            this.btnSaveRule.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRule.TabIndex = 81;
            this.btnSaveRule.Text = "Save";
            this.btnSaveRule.UseVisualStyleBackColor = true;
            this.btnSaveRule.Click += new System.EventHandler(this.btnSaveRule_Click);
            // 
            // dgvRulesList
            // 
            this.dgvRulesList.AllowUserToAddRows = false;
            this.dgvRulesList.AllowUserToDeleteRows = false;
            this.dgvRulesList.AllowUserToResizeRows = false;
            this.dgvRulesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRulesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RuleName,
            this.IsActive,
            this.Subject,
            this.EmailFrom,
            this.id});
            this.dgvRulesList.ContextMenuStrip = this.cmRules;
            this.dgvRulesList.Location = new System.Drawing.Point(15, 35);
            this.dgvRulesList.MultiSelect = false;
            this.dgvRulesList.Name = "dgvRulesList";
            this.dgvRulesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRulesList.Size = new System.Drawing.Size(384, 128);
            this.dgvRulesList.TabIndex = 78;
            this.dgvRulesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRulesList_CellDoubleClick);
            this.dgvRulesList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRulesList_CellMouseEnter);
            // 
            // RuleName
            // 
            this.RuleName.DataPropertyName = "Name";
            this.RuleName.HeaderText = "Rule Name";
            this.RuleName.Name = "RuleName";
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EmailFrom
            // 
            this.EmailFrom.DataPropertyName = "AddressFrom";
            this.EmailFrom.HeaderText = "From";
            this.EmailFrom.Name = "EmailFrom";
            // 
            // id
            // 
            this.id.DataPropertyName = "Mailbox_ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // cmRules
            // 
            this.cmRules.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRuleToolStripMenuItem,
            this.markInactiveToolStripMenuItem,
            this.duplicateRuleToolStripMenuItem});
            this.cmRules.Name = "cmRules";
            this.cmRules.Size = new System.Drawing.Size(151, 70);
            this.cmRules.Opening += new System.ComponentModel.CancelEventHandler(this.cmRules_Opening);
            // 
            // deleteRuleToolStripMenuItem
            // 
            this.deleteRuleToolStripMenuItem.Name = "deleteRuleToolStripMenuItem";
            this.deleteRuleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteRuleToolStripMenuItem.Text = "Delete Rule";
            this.deleteRuleToolStripMenuItem.Click += new System.EventHandler(this.deleteRuleToolStripMenuItem_Click);
            // 
            // markInactiveToolStripMenuItem
            // 
            this.markInactiveToolStripMenuItem.Name = "markInactiveToolStripMenuItem";
            this.markInactiveToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.markInactiveToolStripMenuItem.Text = "Mark Inactive";
            // 
            // duplicateRuleToolStripMenuItem
            // 
            this.duplicateRuleToolStripMenuItem.Name = "duplicateRuleToolStripMenuItem";
            this.duplicateRuleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.duplicateRuleToolStripMenuItem.Text = "Duplicate Rule";
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(211, 169);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(81, 17);
            this.cbIsActive.TabIndex = 75;
            this.cbIsActive.Text = "Rule Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(104, 240);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(250, 20);
            this.txtSubject.TabIndex = 61;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 74;
            this.label15.Text = "Subject :";
            // 
            // txtFromAddress
            // 
            this.txtFromAddress.Location = new System.Drawing.Point(104, 214);
            this.txtFromAddress.Name = "txtFromAddress";
            this.txtFromAddress.Size = new System.Drawing.Size(250, 20);
            this.txtFromAddress.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 73;
            this.label13.Text = "From Address :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "Message Rules";
            // 
            // pbName
            // 
            this.pbName.Image = ((System.Drawing.Image)(resources.GetObject("pbName.Image")));
            this.pbName.Location = new System.Drawing.Point(360, 193);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(18, 15);
            this.pbName.TabIndex = 70;
            this.pbName.TabStop = false;
            // 
            // grpArchiveAttach
            // 
            this.grpArchiveAttach.Controls.Add(this.pbArchiveLocation);
            this.grpArchiveAttach.Controls.Add(this.btnArchiveLocation);
            this.grpArchiveAttach.Controls.Add(this.txtArchiveLocation);
            this.grpArchiveAttach.Controls.Add(this.label10);
            this.grpArchiveAttach.Controls.Add(this.radArchiveYes);
            this.grpArchiveAttach.Controls.Add(this.radArchiveNo);
            this.grpArchiveAttach.Location = new System.Drawing.Point(20, 496);
            this.grpArchiveAttach.Name = "grpArchiveAttach";
            this.grpArchiveAttach.Size = new System.Drawing.Size(337, 56);
            this.grpArchiveAttach.TabIndex = 68;
            this.grpArchiveAttach.TabStop = false;
            this.grpArchiveAttach.Text = "Archive Attachment :";
            // 
            // pbArchiveLocation
            // 
            this.pbArchiveLocation.Image = ((System.Drawing.Image)(resources.GetObject("pbArchiveLocation.Image")));
            this.pbArchiveLocation.Location = new System.Drawing.Point(316, 29);
            this.pbArchiveLocation.Name = "pbArchiveLocation";
            this.pbArchiveLocation.Size = new System.Drawing.Size(18, 15);
            this.pbArchiveLocation.TabIndex = 44;
            this.pbArchiveLocation.TabStop = false;
            this.pbArchiveLocation.Visible = false;
            // 
            // btnArchiveLocation
            // 
            this.btnArchiveLocation.Location = new System.Drawing.Point(284, 29);
            this.btnArchiveLocation.Name = "btnArchiveLocation";
            this.btnArchiveLocation.Size = new System.Drawing.Size(26, 20);
            this.btnArchiveLocation.TabIndex = 16;
            this.btnArchiveLocation.Text = "...";
            this.btnArchiveLocation.UseVisualStyleBackColor = true;
            // 
            // txtArchiveLocation
            // 
            this.txtArchiveLocation.Location = new System.Drawing.Point(66, 29);
            this.txtArchiveLocation.Name = "txtArchiveLocation";
            this.txtArchiveLocation.Size = new System.Drawing.Size(219, 20);
            this.txtArchiveLocation.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
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
            this.radArchiveYes.TabIndex = 13;
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
            this.radArchiveNo.TabIndex = 14;
            this.radArchiveNo.Text = "No";
            this.radArchiveNo.UseVisualStyleBackColor = true;
            // 
            // grpDeleteMail
            // 
            this.grpDeleteMail.Controls.Add(this.radDeleteMailYes);
            this.grpDeleteMail.Controls.Add(this.radMailDeleteNo);
            this.grpDeleteMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDeleteMail.Location = new System.Drawing.Point(243, 271);
            this.grpDeleteMail.Name = "grpDeleteMail";
            this.grpDeleteMail.Size = new System.Drawing.Size(115, 45);
            this.grpDeleteMail.TabIndex = 67;
            this.grpDeleteMail.TabStop = false;
            this.grpDeleteMail.Text = "Delete Message :";
            // 
            // radDeleteMailYes
            // 
            this.radDeleteMailYes.AutoSize = true;
            this.radDeleteMailYes.Location = new System.Drawing.Point(6, 19);
            this.radDeleteMailYes.Name = "radDeleteMailYes";
            this.radDeleteMailYes.Size = new System.Drawing.Size(43, 17);
            this.radDeleteMailYes.TabIndex = 11;
            this.radDeleteMailYes.Text = "Yes";
            this.radDeleteMailYes.UseVisualStyleBackColor = true;
            // 
            // radMailDeleteNo
            // 
            this.radMailDeleteNo.AutoSize = true;
            this.radMailDeleteNo.Checked = true;
            this.radMailDeleteNo.Location = new System.Drawing.Point(55, 19);
            this.radMailDeleteNo.Name = "radMailDeleteNo";
            this.radMailDeleteNo.Size = new System.Drawing.Size(39, 17);
            this.radMailDeleteNo.TabIndex = 12;
            this.radMailDeleteNo.TabStop = true;
            this.radMailDeleteNo.Text = "No";
            this.radMailDeleteNo.UseVisualStyleBackColor = true;
            // 
            // cmbProfileAction
            // 
            this.cmbProfileAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfileAction.FormattingEnabled = true;
            this.cmbProfileAction.Items.AddRange(new object[] {
            "Print",
            "Save",
            "FTP",
            "Forward"});
            this.cmbProfileAction.Location = new System.Drawing.Point(76, 295);
            this.cmbProfileAction.Name = "cmbProfileAction";
            this.cmbProfileAction.Size = new System.Drawing.Size(143, 21);
            this.cmbProfileAction.TabIndex = 62;
            this.cmbProfileAction.SelectedIndexChanged += new System.EventHandler(this.cmbProfileAction_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Rule Actions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Action :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 188);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Rule Name :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 85;
            this.label17.Text = "Rules";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(80, 12);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(66, 17);
            this.rbAll.TabIndex = 86;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Show All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(152, 12);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(79, 17);
            this.rbActive.TabIndex = 87;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active Only";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // rbInactive
            // 
            this.rbInactive.AutoSize = true;
            this.rbInactive.Location = new System.Drawing.Point(236, 12);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(67, 17);
            this.rbInactive.TabIndex = 88;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "In-Active";
            this.rbInactive.UseVisualStyleBackColor = true;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.rbInactive_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbFtpBasic);
            this.tabControl1.Controls.Add(this.tbAdvancedFtp);
            this.tabControl1.Location = new System.Drawing.Point(8, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 143);
            this.tabControl1.TabIndex = 80;
            // 
            // tbFtpBasic
            // 
            this.tbFtpBasic.Controls.Add(this.bbTestFtp);
            this.tbFtpBasic.Controls.Add(this.cbFtpSecure);
            this.tbFtpBasic.Controls.Add(this.edFtpPassword);
            this.tbFtpBasic.Controls.Add(this.label22);
            this.tbFtpBasic.Controls.Add(this.edFtpUsername);
            this.tbFtpBasic.Controls.Add(this.label21);
            this.tbFtpBasic.Controls.Add(this.edFtpfolders);
            this.tbFtpBasic.Controls.Add(this.label20);
            this.tbFtpBasic.Controls.Add(this.edFtpPort);
            this.tbFtpBasic.Controls.Add(this.label19);
            this.tbFtpBasic.Controls.Add(this.edFtpServer);
            this.tbFtpBasic.Controls.Add(this.label11);
            this.tbFtpBasic.Location = new System.Drawing.Point(4, 22);
            this.tbFtpBasic.Name = "tbFtpBasic";
            this.tbFtpBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tbFtpBasic.Size = new System.Drawing.Size(451, 117);
            this.tbFtpBasic.TabIndex = 0;
            this.tbFtpBasic.Text = "Basic FTP Settings";
            this.tbFtpBasic.UseVisualStyleBackColor = true;
            // 
            // bbTestFtp
            // 
            this.bbTestFtp.Location = new System.Drawing.Point(366, 88);
            this.bbTestFtp.Name = "bbTestFtp";
            this.bbTestFtp.Size = new System.Drawing.Size(75, 23);
            this.bbTestFtp.TabIndex = 17;
            this.bbTestFtp.Text = "Test";
            this.bbTestFtp.UseVisualStyleBackColor = true;
            // 
            // cbFtpSecure
            // 
            this.cbFtpSecure.AutoSize = true;
            this.cbFtpSecure.Location = new System.Drawing.Point(10, 88);
            this.cbFtpSecure.Name = "cbFtpSecure";
            this.cbFtpSecure.Size = new System.Drawing.Size(140, 17);
            this.cbFtpSecure.TabIndex = 16;
            this.cbFtpSecure.Text = "Secure FTP Connection";
            this.cbFtpSecure.UseVisualStyleBackColor = true;
            // 
            // edFtpPassword
            // 
            this.edFtpPassword.Location = new System.Drawing.Point(296, 62);
            this.edFtpPassword.Name = "edFtpPassword";
            this.edFtpPassword.Size = new System.Drawing.Size(146, 20);
            this.edFtpPassword.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(237, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Password";
            // 
            // edFtpUsername
            // 
            this.edFtpUsername.Location = new System.Drawing.Point(81, 62);
            this.edFtpUsername.Name = "edFtpUsername";
            this.edFtpUsername.Size = new System.Drawing.Size(142, 20);
            this.edFtpUsername.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "User Name";
            // 
            // edFtpfolders
            // 
            this.edFtpfolders.Location = new System.Drawing.Point(210, 36);
            this.edFtpfolders.Name = "edFtpfolders";
            this.edFtpfolders.Size = new System.Drawing.Size(232, 20);
            this.edFtpfolders.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(132, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Default Folder";
            // 
            // edFtpPort
            // 
            this.edFtpPort.Location = new System.Drawing.Point(43, 36);
            this.edFtpPort.Name = "edFtpPort";
            this.edFtpPort.Size = new System.Drawing.Size(68, 20);
            this.edFtpPort.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Port";
            // 
            // edFtpServer
            // 
            this.edFtpServer.Location = new System.Drawing.Point(117, 11);
            this.edFtpServer.Name = "edFtpServer";
            this.edFtpServer.Size = new System.Drawing.Size(325, 20);
            this.edFtpServer.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "FTP Server Address";
            // 
            // tbAdvancedFtp
            // 
            this.tbAdvancedFtp.Controls.Add(this.bbKeyPath);
            this.tbAdvancedFtp.Controls.Add(this.edFingerPrint);
            this.tbAdvancedFtp.Controls.Add(this.edKeyPath);
            this.tbAdvancedFtp.Controls.Add(this.label24);
            this.tbAdvancedFtp.Controls.Add(this.label23);
            this.tbAdvancedFtp.Location = new System.Drawing.Point(4, 22);
            this.tbAdvancedFtp.Name = "tbAdvancedFtp";
            this.tbAdvancedFtp.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdvancedFtp.Size = new System.Drawing.Size(451, 117);
            this.tbAdvancedFtp.TabIndex = 1;
            this.tbAdvancedFtp.Text = "Advanced FTP Settings";
            this.tbAdvancedFtp.UseVisualStyleBackColor = true;
            // 
            // bbKeyPath
            // 
            this.bbKeyPath.Location = new System.Drawing.Point(405, 8);
            this.bbKeyPath.Name = "bbKeyPath";
            this.bbKeyPath.Size = new System.Drawing.Size(28, 23);
            this.bbKeyPath.TabIndex = 4;
            this.bbKeyPath.Text = "...";
            this.bbKeyPath.UseVisualStyleBackColor = true;
            // 
            // edFingerPrint
            // 
            this.edFingerPrint.Location = new System.Drawing.Point(8, 49);
            this.edFingerPrint.Multiline = true;
            this.edFingerPrint.Name = "edFingerPrint";
            this.edFingerPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edFingerPrint.Size = new System.Drawing.Size(437, 60);
            this.edFingerPrint.TabIndex = 3;
            // 
            // edKeyPath
            // 
            this.edKeyPath.Location = new System.Drawing.Point(106, 9);
            this.edKeyPath.Name = "edKeyPath";
            this.edKeyPath.Size = new System.Drawing.Size(300, 20);
            this.edKeyPath.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Server Fingerprint";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Digital Key Path";
            // 
            // frmJobProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 624);
            this.Controls.Add(this.gbRules);
            this.Controls.Add(this.gbMailboxes);
            this.Controls.Add(this.btnClose);
            this.Name = "frmJobProfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Profiles";
            this.Load += new System.EventHandler(this.frmJobProfiles_Load);
            this.cmJobProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMailbox)).EndInit();
            this.gbMailboxes.ResumeLayout(false);
            this.gbMailboxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMailBoxList)).EndInit();
            this.cmMailBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMailPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMailUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMailServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMailServer)).EndInit();
            this.gbRules.ResumeLayout(false);
            this.gbRules.PerformLayout();
            this.gbFtpDetails.ResumeLayout(false);
            this.gbPrinterDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDefaultPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRulesList)).EndInit();
            this.cmRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            this.grpArchiveAttach.ResumeLayout(false);
            this.grpArchiveAttach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArchiveLocation)).EndInit();
            this.grpDeleteMail.ResumeLayout(false);
            this.grpDeleteMail.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbFtpBasic.ResumeLayout(false);
            this.tbFtpBasic.PerformLayout();
            this.tbAdvancedFtp.ResumeLayout(false);
            this.tbAdvancedFtp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog fldArchiveLocation;
        private System.Windows.Forms.PrintDialog printDialogSelect;
        private System.Data.DataSet dsMailbox;
        private System.Data.DataSet dsMBRules;
        private System.Windows.Forms.ContextMenuStrip cmJobProfile;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateDeActivateProfileToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbMailboxes;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvMailBoxList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMailTo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbMailPassword;
        private System.Windows.Forms.PictureBox pbMailUsername;
        private System.Windows.Forms.PictureBox pbMailServerPort;
        private System.Windows.Forms.PictureBox pbMailServer;
        private System.Windows.Forms.Button btnTestMailSettings;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMailPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMailUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMailSecurity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMailPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMailServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbRules;
        private System.Windows.Forms.Button btnCancelRule;
        private System.Windows.Forms.Button btnNewRule;
        private System.Windows.Forms.Button btnSaveRule;
        private System.Windows.Forms.DataGridView dgvRulesList;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFromAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbDefaultPrinter;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cmbPrintList;
        private System.Windows.Forms.GroupBox grpArchiveAttach;
        private System.Windows.Forms.PictureBox pbArchiveLocation;
        private System.Windows.Forms.Button btnArchiveLocation;
        private System.Windows.Forms.TextBox txtArchiveLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radArchiveYes;
        private System.Windows.Forms.RadioButton radArchiveNo;
        private System.Windows.Forms.GroupBox grpDeleteMail;
        private System.Windows.Forms.RadioButton radDeleteMailYes;
        private System.Windows.Forms.RadioButton radMailDeleteNo;
        private System.Windows.Forms.ComboBox cmbProfileAction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailBox_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.ContextMenuStrip cmMailBoxList;
        private System.Windows.Forms.ToolStripMenuItem deleteMailboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateMailboxToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmRules;
        private System.Windows.Forms.ToolStripMenuItem deleteRuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markInactiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateRuleToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbFtpDetails;
        private System.Windows.Forms.GroupBox gbPrinterDetails;
        private System.Windows.Forms.RadioButton rbInactive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFtpBasic;
        private System.Windows.Forms.Button bbTestFtp;
        private System.Windows.Forms.CheckBox cbFtpSecure;
        private System.Windows.Forms.TextBox edFtpPassword;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox edFtpUsername;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox edFtpfolders;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox edFtpPort;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox edFtpServer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tbAdvancedFtp;
        private System.Windows.Forms.Button bbKeyPath;
        private System.Windows.Forms.TextBox edFingerPrint;
        private System.Windows.Forms.TextBox edKeyPath;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
    }
}
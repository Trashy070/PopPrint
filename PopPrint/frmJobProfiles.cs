using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using WinSCP;

namespace PopPrint
{
    public partial class frmJobProfiles : Form
    {
        string ruleMode;
        int ruleRow;
        string mailboxMode;
        int mailboxRow;
        public frmJobProfiles()
        {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void btnArchiveLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = txtArchiveLocation.Text;
            folderBrowserDialog.ShowDialog();
            txtArchiveLocation.Text = folderBrowserDialog.SelectedPath;
        }

        private void frmJobProfiles_Load(object sender, EventArgs e)
        {
            ClearErrorImages();
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            GetPrinterList();
            GetProfileXMLData();
            rbAll.Checked = true;
            gbFtpDetails.Visible = false;
            gbPrinterDetails.Visible = false;

        }

        public void CreateProfileXML(string appprofilexml)
        {
            //First create the XDocument instance
            // Note that the Xdocument is created in one line. I have separated it to make it easier to read
            XDocument xmlProfileConf = new XDocument(
                new XDeclaration("1.0", "UTF-8", "Yes"),
                new XElement("Mailboxes",
                    new XElement("Mailbox",
                        new XElement("PopServer"),
                        new XElement("PopUserName"),
                        new XElement("PopPassword"),
                        new XElement("PopPort"),
                        new XElement("PopSSL"),
                        new XElement("AddressTo"),
                        new XElement("Rule",
                                        new XElement("Name"),
                                        new XElement("IsActive"),
                                        new XElement("PopAction"),
                                        new XElement("PopDelete"),
                                        new XElement("ArchiveFile"),
                                        new XElement("ArchiveLocation"),
                                        new XElement("AddressFrom"), 
                                        new XElement("Subject"), 
                                        new XElement("PrintQueue"),
                                        new XElement("FtpServer"),
                                        new XElement("FtpPort"),
                                        new XElement("FtpUserName"),
                                        new XElement("FtpPassword"),
                                        new XElement("FtpSecure"),
                                        new XElement("FtpFolder"),
                                        new XElement("FtpKeyLocation"),
                                        new XElement("FtpFingerPrint")
                                        
                                    )
                                     )));
            xmlProfileConf.Save(appprofilexml);
        }

        public void ClearErrorImages()
        {
            //This is just used to setup the form. hide error images etc. 
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    ((PictureBox)control).Visible = false;
                }
            }
        }


        public void GetPrinterList()
        {
            String myInstalledPrinters;
            for (int p = 0; p < PrinterSettings.InstalledPrinters.Count; p++)
            {
                myInstalledPrinters = PrinterSettings.InstalledPrinters[p];
                cmbPrintList.Items.Add(myInstalledPrinters);

            }
        }

        public void GetProfileXMLData()
        {

            if (!File.Exists(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml")))
            {
                CreateProfileXML(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
            }
            else
            {
                dsMailbox.ReadXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));


                dgvMailBoxList.DataSource = dsMailbox.Tables["Mailbox"];
                try
                {
                    dgvRulesList.DataSource = dsMailbox.Tables["Mailbox"];
                    dgvRulesList.DataMember = "Mailbox_Rule";
                }
                catch (Exception ex)
                {

                }
                dgvMailBoxList.Refresh();



            }
        }


        private void btnTest_Click(object sender, EventArgs e)
        {
            //Create a PrintDocument object
            PrintDocument pd = new PrintDocument();

            //Set PrinterName as the selected printer in the printers list
            pd.PrinterSettings.PrinterName = cmbPrintList.SelectedItem.ToString();

            //Add PrintPage event handler
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            //Print the document
            pd.Print();
        }

        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {

            //Get the Graphics object
            Graphics g = ev.Graphics;

            //Create a font Arial with size 16
            Font font = new Font("Arial", 16);

            //Create a solid brush with black color
            SolidBrush brush = new SolidBrush(Color.Black);

            //Draw "Hello Printer!";
            g.DrawString("Hello Printer!",
            font, brush,
            new Rectangle(20, 20, 200, 100));
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm(gbMailboxes);
            rbAll.Checked = true;
            if (!btnSave.Enabled)
            {
                btnSave.Enabled = true;
            }
            dgvMailBoxList.ClearSelection();
            btnNew.Enabled = false;
            btnCancel.Enabled = true;
            cmbMailSecurity.SelectedIndex = 0;
            mailboxMode = "New";
        }

        public void ClearForm(Control controlCollection)
        {
            //This will recursively clear each TextBox and Set the ComboBox to the none selected option
            // Each control (ie the Form) is a container of Controls.
            // The Foreach loop checks each control if it is a Text Box or a Combobox and sets it. 
            // If the Control is another Container (ie Panel or Group Box) it will run the method again. 
            // These are called recursive loops. 
            foreach (Control control in controlCollection.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control is GroupBox)
                {
                    ClearForm(control);
                }

            }
        }

        private void DoNewMailbox()
        {
            try
            {

                // Get the Row ID of the Selected Row. 
                //If it is a new row then the Selected Row will be -1

                DataRow newRow;
                if (dsMailbox.Tables["Mailbox"].Rows.Count == 1)
                {
                    newRow = dsMailbox.Tables["MailBox"].Rows[0];
                }
                else
                {
                    newRow = dsMailbox.Tables["Mailbox"].NewRow();
                }
                newRow["PopServer"] = txtMailServer.Text.Trim();
                newRow["PopPort"] = txtMailPort.Text.Trim();
                newRow["PopUserName"] = txtMailUser.Text.Trim();
                newRow["PopPassword"] = txtMailPass.Text.Trim();
                newRow["PopSSL"] = cmbMailSecurity.Text.Trim();
                newRow["AddressTo"] = txtMailTo.Text;

                if (dsMailbox.Tables["Mailbox"].Rows.Count > 1)
                {
                    dsMailbox.Tables["Mailbox"].Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                CreateProfileXML(Globals.ProfileXml);
                GetProfileXMLData();
                DoNewMailbox();
            }
            dsMailbox.AcceptChanges();
            //Write the Changes to the XML File immediately
            dsMailbox.WriteXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));

        }

        private void DoEditMailbox()
        {
            DataRow row = ((DataRowView)dgvMailBoxList.Rows[mailboxRow].DataBoundItem).Row;
            row["PopServer"] = txtMailServer.Text.Trim();
            row["PopPort"] = txtMailPort.Text.Trim();
            row["PopUserName"] = txtMailUser.Text.Trim();
            row["PopPassword"] = txtMailPass.Text.Trim();
            row["PopSSL"] = cmbMailSecurity.Text.Trim();
            row["AddressTo"] = txtMailTo.Text;
            // Get the Row ID of the Selected Row. 
            //If it is a new row then the Selected Row will be -1

            int mbId = (int)dgvMailBoxList.Rows[dgvMailBoxList.CurrentRow.Index].Cells["Mailbox_id"].Value;
            dsMailbox.AcceptChanges();
            //Write the Changes to the XML File immediately
            dsMailbox.WriteXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {



            if (ValidateAll(gbMailboxes))
            {
                //Once Validated we can then save the record. 

                //First create a new instance of the Table.Row
                //This inherits all of the fields that the table has
                switch (mailboxMode)
                {
                    case "New":
                        DoNewMailbox();
                        break;
                    case "Edit":
                        DoEditMailbox();
                        break;
                }

                btnNew.Enabled = true;
                btnCancel.Enabled = false;
                //Save changes to the table. 
                dsMailbox.AcceptChanges();
                //Write the Changes to the XML File immediately
                dsMailbox.WriteXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
                btnSave.Enabled = false;
                MessageBox.Show("Job Mailbox Updated", "Save Job Profile");
                //GetProfileXMLData();
            }

        }



        public bool ValidateAll(Control controlCollection)
        {
            //This is the Validation rule so that the right information is saved.
            //_errorlist will hold a list of all errors/validations 

            string _errorList = "";
            bool result = true;
            //Reset the Error Icons.
            ClearErrorImages();

            if (controlCollection.Name == "gbRules")
            {

            }
            else if (controlCollection.Name == "gbMailboxes")
            {
                if (string.IsNullOrEmpty(txtMailServer.Text.Trim()))
                {
                    result = false;
                    _errorList += "Mail Server/IP cannot be blank. \r\n";
                    pbMailServer.Visible = true;
                }
                if (string.IsNullOrEmpty(txtMailPort.Text.Trim()))
                {
                    result = false;
                    _errorList += "Mail Server Port cannot be blank. \r\n";
                    pbMailServerPort.Visible = true;
                }
                if (string.IsNullOrEmpty(txtMailUser.Text.Trim()))
                {
                    result = false;
                    _errorList += "Username cannot be blank. \r\n";
                    pbMailUsername.Visible = true;
                }
                if (string.IsNullOrEmpty(txtMailPass.Text.Trim()))
                {
                    result = false;
                    _errorList += "Password cannot be blank. \r\n";
                    pbMailPassword.Visible = true;
                }
            }
            if (!result)
            {
                MessageBox.Show(_errorList, "Unable to Save Profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to cancel changes?", "Save Mailbox Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                btnNew.Enabled = true;
                dgvMailBoxList.Rows[0].Selected = true;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                mailboxMode = "Cancel";
                ClearForm(gbMailboxes);


            }
        }

        private void cmJobProfile_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get the Row index of the right menu delete (or multitples) 
            int rowIndex = dgvMailBoxList.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DialogResult drDelete = MessageBox.Show("Are you sure you wish to delete Selected Profile(s)?", "Delete from Job Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drDelete == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvMailBoxList.SelectedRows)
                {
                    dgvMailBoxList.Rows.Remove(row);
                }
                dsMailbox.AcceptChanges();
                //Write the changes immediately
                dsMailbox.WriteXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));

            }
        }

        private void dgvJobProfileList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //This is the update/Edit
            //First get all the information to edit/View.
            mailboxMode = "Edit";
            mailboxRow = e.RowIndex;
            DataRow row = ((DataRowView)dgvMailBoxList.Rows[e.RowIndex].DataBoundItem).Row;
            txtMailServer.Text = row["PopServer"].ToString();
            txtMailPort.Text = row["PopPort"].ToString();
            txtMailUser.Text = row["PopUserName"].ToString();
            txtMailPass.Text = row["PopPassword"].ToString();
            cmbMailSecurity.Text = row["PopSSL"].ToString();
            txtMailTo.Text = row["AddressTo"].ToString();

            btnNew.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

        }



        public void FilterActiveProfiles()
        {
            //Quick and dirty filter that filters the Active/Inactive
            string filter = "";
            foreach (RadioButton rb in gbRules.Controls)
            {
                if (rb.Checked)
                {
                    switch (rb.Name)
                    {
                        case "rbAll":
                            {
                                filter = "";
                                break;
                            }
                        case "rbActive":
                            {
                                filter = "IsActive = 'Yes'";
                                break;
                            }
                        case "rbInactive":
                            {
                                filter = "IsActive = 'No'";
                                break;
                            }
                    }
                }
            }
            //    DataView dv = new DataView(dsMailbox.Tables["Rule"]);
            //   dv.RowFilter = filter;
            // dgvRulesList.DataSource = dv;

        }

        private void cmbActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterActiveProfiles();
        }

        private void btnTestMailSettings_Click(object sender, EventArgs e)
        {
            //I created an overloaded Constructor. (Look at the frmTestEmail)
            // In the Constructor I pass the mail settings to test. 
            frmTestEmail testEmail = new frmTestEmail(txtMailServer.Text, txtMailPort.Text, txtMailUser.Text, txtMailPass.Text, cmbMailSecurity.Text);
            testEmail.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
            dsMailbox.ReadXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
            dgvMailBoxList.DataSource = dsMailbox.Tables["Mailbox"];
            dgvMailBoxList.DataSource = ds.Tables[0];
        }

        private void btnNewRule_Click(object sender, EventArgs e)
        {
            ClearForm(gbRules);
            rbAll.Checked = true;

            if (!btnSaveRule.Enabled)
            {
                btnSaveRule.Enabled = true;
            }
            btnNewRule.Enabled = false;
            btnCancelRule.Enabled = true;
            ruleMode = "New";
        }

        private void btnCancelRule_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to cancel changes?", "Save Mailbox Rule", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                btnNewRule.Enabled = true;
                btnCancelRule.Enabled = false;
                btnSaveRule.Enabled = false;
                ClearForm(this);

            }
        }

        private void btnSaveRule_Click(object sender, EventArgs e)
        {

            if (ValidateAll(gbRules))
            {
                //Once Validated we can then save the record. 
                btnNew.Enabled = true;
                btnCancel.Enabled = false;
                //First create a new instance of the Table.RowF
                //This inherits all of the fields that the table has

                switch (ruleMode)
                {
                    case "New":
                        DoNewRule();
                        break;
                    case "Cancel":
                        break;
                    case "Edit":
                        DoEditRule();
                        break;

                }





                MessageBox.Show("Mailbox Rule Updated", "Save Mailbox Rule");
            }
        }

        private void btnNewRule_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelRule_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Are you sure you wish to cancel changes?", "Save Mailbox Rules Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    btnNewRule.Enabled = true;
                    btnCancelRule.Enabled = false;
                    btnSaveRule.Enabled = false;
                    ClearForm(gbRules);
                    ruleMode = "Cancelled";
                }
            }
        }

        private void DoEditRule()
        {
            //DataRow row = dsMailbox.Tables["Rule"].Select("Rule_id = " + ruleRow);
            DataRow row = ((DataRowView)dgvRulesList.Rows[ruleRow].DataBoundItem).Row;
            row["Name"] = txtName.Text.Trim();

            if (cbIsActive.Checked)
            {
                row["IsActive"] = "Yes";
            }
            else
            {
                row["IsActive"] = "No";
            }
            switch (cmbProfileAction.Text.Trim())
            {
                case "Print":

                    break;
            }
            row["AddressFrom"] = txtFromAddress.Text.Trim();
            row["Subject"] = txtSubject.Text.Trim();
            row["PopAction"] = cmbProfileAction.Text.Trim();
            if (radDeleteMailYes.Checked)
            {
                row["PopDelete"] = "Yes";
            }
            else
            {
                row["PopDelete"] = "No";
            }
            if (radArchiveYes.Checked)
            {
                row["ArchiveFile"] = "Yes";
                ;
            }
            else
            {
                row["ArchiveFile"] = "No";
            }
            row["ArchiveLocation"] = txtArchiveLocation.Text.Trim();
            btnCancelRule.Enabled = false;
            if (gbFtpDetails.Visible)
            {
                row["FtpServer"] = edFtpServer.Text;
                row["FtpPort"] = edFtpPort.Text;
                row["FtpUserName"] = edFtpUsername.Text;
                row["FtpPassword"] = edFtpPassword.Text;
                row["FtpFolder"] = edFtpfolders.Text;
                if (cbFtpSecure.Checked)
                {
                    row["FtpSecure"] = true;
                }
                else
                {
                    row["FtpSecure"] = false;
                }

            }
            if (gbPrinterDetails.Visible)
            {
                row["PrintQueue"] = cmbPrintList.Text.Trim();
            }
            DataTable tb = dsMailbox.Tables["Rule"];
            // dsMailbox.Tables["Rule"].Rows.Add(row);
            //Save changes to the table. 
            dsMailbox.AcceptChanges();
            //Write the Changes to the XML File immediately
            //dsMailbox.WriteXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
            btnSaveRule.Enabled = false;
            btnNewRule.Enabled = true;
        }
        private void DoNewRule()
        {
            DataRow newRow = dsMailbox.Tables["Rule"].NewRow();
            int mbId = (int)dgvMailBoxList.Rows[dgvMailBoxList.CurrentRow.Index].Cells["Mailbox_id"].Value;
            newRow["Mailbox_id"] = mbId;
            //Next I fill the fields of the newrecord instance
            newRow["Name"] = txtName.Text.Trim();

            if (cbIsActive.Checked)
            {
                newRow["IsActive"] = "Yes";
            }
            else
            {
                newRow["IsActive"] = "No";
            }
            switch (cmbProfileAction.Text.Trim())
            {
                case "Print":

                    break;
            }
            newRow["AddressFrom"] = txtFromAddress.Text.Trim();
            newRow["Subject"] = txtSubject.Text.Trim();
            newRow["PopAction"] = cmbProfileAction.Text.Trim();
            if (radDeleteMailYes.Checked)
            {
                newRow["PopDelete"] = "Yes";
            }
            else
            {
                newRow["PopDelete"] = "No";
            }
            if (radArchiveYes.Checked)
            {
                newRow["ArchiveFile"] = "Yes";
                ;
            }
            else
            {
                newRow["ArchiveFile"] = "No";
            }
            newRow["ArchiveLocation"] = txtArchiveLocation.Text.Trim();
            btnCancelRule.Enabled = false;
            if (gbFtpDetails.Visible)
            {
                newRow["FtpServer"] = edFtpServer.Text;
                newRow["FtpPort"] = edFtpPort.Text;
                newRow["FtpUserName"] = edFtpUsername.Text;
                newRow["FtpPassword"] = edFtpPassword.Text;
                newRow["FtpFolder"] = edFtpfolders.Text;
                if (cbFtpSecure.Checked)
                {
                    newRow["FtpSecure"] = true;
                }
                else
                {
                    newRow["FtpSecure"] = false;
                }

            }
            if (gbPrinterDetails.Visible)
            {
                newRow["PrintQueue"] = cmbPrintList.Text.Trim();
            }
            DataTable tb = dsMailbox.Tables["Rule"];
            dsMailbox.Tables["Rule"].Rows.Add(newRow);
            //Save changes to the table. 
            dsMailbox.AcceptChanges();
            //Write the Changes to the XML File immediately
            dsMailbox.WriteXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
            btnSaveRule.Enabled = false;
            btnNewRule.Enabled = true;
        }
        private void dgvMailBoxList_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvMailBoxList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dgvRulesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //This is the update/Edit
            //First get all the information to edit/View.

            // ruleRow = (int)dgvRulesList.Rows[dgvRulesList.CurrentRow.Index].Cells["Rule_id"].Value;
            ruleRow = e.RowIndex;

            DataRow row = ((DataRowView)dgvRulesList.Rows[e.RowIndex].DataBoundItem).Row;
            txtName.Text = row["Name"].ToString();
            txtFromAddress.Text = row["AddressFrom"].ToString();
            txtSubject.Text = row["subject"].ToString();

            if (row["IsActive"].ToString() == "Yes")
            {
                cbIsActive.Checked = true;
            }
            else
            {
                cbIsActive.Checked = false;
            }

            if (row["ArchiveFile"].ToString() == "Yes")
            {
                radArchiveYes.Checked = true;
                txtArchiveLocation.Text = row["ArchiveLocation"].ToString();
            }
            else
            {
                radArchiveNo.Checked = true;
            }
            switch (row["PopAction"])
            {
                case "FTP":
                    edFtpServer.Text = row["FtpServer"].ToString();
                    edFtpPort.Text = row["FtpPort"].ToString();
                    edFtpUsername.Text = row["FtpUserName"].ToString();
                    edFtpPassword.Text = row["FtpPassword"].ToString();
                    edFtpfolders.Text = row["FtpFolder"].ToString();
                    break;
                case "Print":
                    cmbPrintList.Text = row["PrintQueue"].ToString();
                    break;

            }
            cmbProfileAction.Text = row["PopAction"].ToString();


            if (row["PopDelete"].ToString() == "Yes")
            {
                radDeleteMailYes.Checked = true;
            }
            else
            {
                radMailDeleteNo.Checked = true;
            }
            btnNewRule.Enabled = false;
            btnCancelRule.Enabled = true;
            btnSaveRule.Enabled = true;
            ruleMode = "Edit";

        }

        private void deleteMailboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Are you sure you wish to Delete the Mailbox and all its Rules", "Delete Mailbox from Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dresult == DialogResult.Yes)
            {

                foreach (DataGridViewRow drMailBox in dgvMailBoxList.SelectedRows)
                {
                    dsMailbox.Tables["MailBox"].Rows.RemoveAt(drMailBox.Index);
                }
                try
                {
                    int mbId = (int)dgvMailBoxList.Rows[dgvMailBoxList.CurrentRow.Index].Cells["Mailbox_id"].Value;
                    DataRow[] dr = dsMailbox.Tables["Rule"].Select("MailBox_id = " + mbId);
                    foreach (DataRow drDel in dr)
                    {
                        drDel.Delete();
                    }
                }
                catch (Exception ex)
                {

                }



                // dsMailbox.Tables["Mailbox"].Rows[mbId].Delete();
                dsMailbox.AcceptChanges();
                dsMailbox.WriteXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
                GetProfileXMLData();
            }


        }

        private void cmbProfileAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProfileAction.Text)
            {
                case "Print":
                    gbPrinterDetails.Visible = true;
                    gbPrinterDetails.BringToFront();
                    gbFtpDetails.Visible = false;
                    break;
                case "FTP":
                    gbPrinterDetails.Visible = false;
                    gbFtpDetails.Visible = true;
                    gbFtpDetails.BringToFront();
                    break;
                case "Save":
                    gbPrinterDetails.Visible = false;
                    gbFtpDetails.Visible = false;
                    break;


            }
        }

        private void bbTestFtp_Click(object sender, EventArgs e)
        {

            SessionOptions sessionOptions = new SessionOptions
            {
                HostName = edFtpServer.Text,
                PortNumber = int.Parse(edFtpPort.Text),
                UserName = edFtpUsername.Text,
                Password = edFtpPassword.Text
            };
            if (cbFtpSecure.Checked)
            {
                sessionOptions.Protocol = Protocol.Sftp;
            }
            else
            {
                sessionOptions.Protocol = Protocol.Ftp;
            }
            try
            {
                using (Session session = new Session())
                {
                    session.Open(sessionOptions);
                    if (session.Opened)
                    {
                        MessageBox.Show("FTP Server Connected and Logged in", "FTP Server Test", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                    }
                }
            }
            catch (SessionRemoteException ex)
            {
                MessageBox.Show("FTP Server Error: " + ex.Message, "FTP Server Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cmRules_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private DataGridViewCellEventArgs mouseLocation;

        private void deleteRuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dresult = MessageBox.Show("Are you sure you wish to Delete the select Rule(s)", "Delete Rule from Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dresult == DialogResult.Yes)
            {

                foreach (DataGridViewRow dr in dgvRulesList.SelectedRows)
                {
                    dsMailbox.Tables["Rule"].Rows.RemoveAt(dr.Index);
                }
            }
            dsMailbox.AcceptChanges();
            dsMailbox.WriteXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));

        }

        private void dgvRulesList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;


        }

        private void cmMailBoxList_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveProfiles();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveProfiles();
        }

        private void rbInactive_CheckedChanged(object sender, EventArgs e)
        {
            FilterActiveProfiles();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WinSCP;

namespace PopPrint
{
    public partial class frmMain : Form


    {
        public System.Timers.Timer tmrMain;
        public DataSet dsProfiles;

        private void tmrMain_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (btnTimer.Text == "&Stop")
            {
                tmrMain.Stop();
                ProcessJobs();
                tmrMain.Start();
            }
            else
            {
                tmrMain.Stop();
            }
        }

        public void PrintJobs(string varPrintTo)
        {
            DirectoryInfo di = new DirectoryInfo(Globals.TempPath);
            foreach (var xmlFile in di.GetFiles("*.*"))
            {
                FileInfo fx = new FileInfo(xmlFile.FullName);
                if (PrintDoc(xmlFile.FullName, varPrintTo))
                {
                    fx.Delete();
                }
            }


        }

        public frmMain()
        {
            InitializeComponent();
            slStatus.Text = "Timed Processes Stopped";
            tmrMain = new System.Timers.Timer();
            dsProfiles = new DataSet();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSysProfile sysProfile = new frmSysProfile();
            sysProfile.Show();

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        public void ProcessJobs()
        {
            Program.AddRTBText(rtbStatus, "Processing Jobs");
            // Load Mailbox List
            foreach (DataRow row in dsProfiles.Tables["Mailbox"].Rows)
            {
                //Create list of profiles that are attached to the Current Mailbox
                DataRow[] drRule = dsProfiles.Tables["Rule"].Select("MailBox_id = " + row["Mailbox_id"]);
                ProfileMailServer mserver = new ProfileMailServer();
                mserver.Hostname = row["PopServer"].ToString();
                mserver.Port = int.Parse((row["PopPort"].ToString()));
                mserver.UserName = row["PopUsername"].ToString();
                mserver.Password = row["PopPassword"].ToString();
                mserver.SSL = row["PopSSL"].ToString();
                mserver.AddressTo = row["AddressTo"].ToString();
                //Create list of Messages from Current mailbox. 
                Program.AddRTBText(rtbStatus, String.Format("{0:g} ", DateTime.Now) + " Connecting to " + mserver.Hostname + " for mailbox : " + mserver.AddressTo);
                List<MsgSummary> msgList = RetrieveEmails(mserver);

                if (msgList == null)
                {
                    Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " No Email found. Moving to next Profile.", Color.Gray);
                }
                else
                {
                    foreach (MsgSummary msg in msgList)
                    {
                        if (msg.MsgFile != null)
                        {
                            foreach (MsgAtt att in msg.MsgFile)
                            {
                                bool ruleFound = false;
                                foreach (DataRow rule in drRule)
                                {
                                    if (!ruleFound)
                                    {
                                        //Loop through each profile to find valid rule
                                        ProfileMessage pMessage = new ProfileMessage();
                                        pMessage.AddressFrom = rule["AddressFrom"].ToString();
                                        pMessage.Subject = rule["Subject"].ToString();
                                        pMessage.Action = rule["PopAction"].ToString();
                                        pMessage.FTPServer = rule["FtpServer"].ToString();
                                        pMessage.FTPFolder = rule["FtpFolder"].ToString();
                                        pMessage.FTPPass = rule["FtpPassWord"].ToString();
                                        pMessage.FTPPort = rule["FtpPort"].ToString();
                                        pMessage.FTPUser = rule["FtpUserName"].ToString();
                                        pMessage.ProfilePrinter = rule["PrintQueue"].ToString();
                                        if (string.IsNullOrEmpty(rule["FtpSecure"].ToString()))
                                        {
                                            pMessage.Secure = false;
                                        }
                                        else
                                            pMessage.Secure = bool.Parse(rule["FtpSecure"].ToString());

                                        if (MsgValid(msg, att, pMessage.AddressFrom, pMessage.Subject, ""))
                                        {
                                            switch (pMessage.Action)
                                            {
                                                case "FTP":
                                                    Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Establishing FTP Connection for profile :" + pMessage.ProfileName, Color.Black);
                                                    SessionOptions sessionOptions = new SessionOptions
                                                    {
                                                        HostName = pMessage.FTPServer,
                                                        PortNumber = int.Parse(pMessage.FTPPort),
                                                        UserName = pMessage.FTPUser,
                                                        Password = pMessage.FTPPass
                                                    };
                                                    if (pMessage.Secure)
                                                    {
                                                        sessionOptions.Protocol = Protocol.Sftp;
                                                    }
                                                    else
                                                    {
                                                        sessionOptions.Protocol = Protocol.Ftp;
                                                    }
                                                    try
                                                    {
                                                        TransferOperationResult tr;
                                                        using (Session session = new Session())
                                                        {
                                                            session.Open(sessionOptions);
                                                            if (session.Opened)
                                                            {
                                                                Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Connected to " + pMessage.FTPServer + ". Sending file  :" + att.AttFilename, Color.Black);
                                                                TransferOptions tOptions = new TransferOptions();
                                                                tOptions.OverwriteMode = OverwriteMode.Overwrite;
                                                                tr = session.PutFiles(att.AttFilename.FullName, pMessage.FTPFolder, true, tOptions);
                                                                Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Results: ", Color.Black);
                                                                if (tr.IsSuccess)
                                                                {

                                                                    MailModule.DeleteMessage(mserver.Hostname, mserver.Port, mserver.SSL, mserver.UserName, mserver.Password, msg.MsgId);
                                                                }
                                                                else
                                                                {
                                                                    Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Transfer Result is invalid: ", Color.Black);
                                                                }

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
                                                    break;

                                                case "Print":
                                                    bool filePrinted = false;
                                                    string fileType = att.AttFilename.Extension;
                                                    Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Now Printing " + att.AttFilename.FullName, Color.Black);
                                                    filePrinted = PrintDoc(att.AttFilename.FullName, pMessage.ProfilePrinter);
                                                    if (filePrinted)
                                                    {
                                                        Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Printed Ok.", Color.Black);
                                                        MailModule.DeleteMessage(mserver.Hostname, mserver.Port, mserver.SSL, mserver.UserName, mserver.Password, msg.MsgId);

                                                    }
                                                    else
                                                    {
                                                        Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Printing Failed !!", Color.Red);
                                                    }
                                                    break;
                                            }
                                            ruleFound = true;

                                        }

                                        //Process message against Profile
                                        Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Checking: " + pMessage.ProfileName, Color.Black);
                                    }
                                }
                                if (!ruleFound)
                                {
                                    Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Invalid email found. Deleting message. From : " + msg.MsgFrom + " Subject: " + msg.MsgSubject, Color.Red); ;
                                    MailModule.DeleteMessage(mserver.Hostname, mserver.Port, mserver.SSL, mserver.UserName, mserver.Password, msg.MsgId);
                                    ruleFound = true;
                                }
                            }




                            //Looping through messages (and Attachments) 
                        }
                    }
                }



                // PrintJobs(mserver.ProfilePrinter);
            }

        }

        public List<MsgSummary> RetrieveEmails(ProfileMailServer mailserver)
        {
            List<MsgSummary> msgTodo = new List<MsgSummary>();
            //This will Check the Mail against the Profile MailServer and the MessageType from the Profile. 
            try
            {

                msgTodo = MailModule.GetMail(mailserver.Hostname, mailserver.Port, mailserver.SSL, mailserver.UserName, mailserver.Password);

                if (msgTodo.Count == 0)
                {

                    return null;
                }
            }
            catch (Exception ex)
            {
                Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Error Retrieving Email for " + mailserver.Hostname + ": - " + ex.Message, Color.Red);
                // MailModule.sendMsg("", Globals.AlertsTo, "Error Retrieving Email for " + dr["P_USERNAME"].ToString(), "Error Retrieving Email for " + dr["P_USERNAME"].ToString() + ": " + ex.Message);
            }
            return msgTodo;
        }

        public Boolean MsgValid(MsgSummary MsgtoValid, MsgAtt Attachment, String SenderEmail, String Subject, String FileType)
        {

            String strValid;
            strValid = "";
            Boolean bValid = false;
            bool fromAddress = false;
            bool subject = false;

            // Cannot have both Subject AND email empty. However can have empty email address. 
            if (string.IsNullOrEmpty(SenderEmail) && !string.IsNullOrEmpty(Subject))
                fromAddress = true;
            else
            // If email address contains Sender OR it matches completely
                if (MsgtoValid.MsgFrom.ToLower().Contains(SenderEmail.ToLower()) || MsgtoValid.MsgFrom.ToLower() == SenderEmail.ToLower())
                fromAddress = true;

            // If the Email address is valid and Subject is blank            
            if (string.IsNullOrEmpty(Subject) && fromAddress)
                subject = true;
            else
            // If Subject contains the Subject OR subject matches completely 
                if (MsgtoValid.MsgSubject.ToLower().Contains(Subject.ToLower()) || MsgtoValid.MsgSubject.ToLower() == Subject.ToLower())
                subject = true;

            if (fromAddress && subject)
            {
                bValid = true;
            }
            else
            {
                bValid = false;
                Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Unable to match Receive profile:  Sender:" + SenderEmail + " Subject:" + Subject, Color.Red);
            }
            return bValid;
        }

        public bool PrintDoc(string filetoPrint, string varPrintTo)
        {
            bool result = false;
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(filetoPrint); //in this pass the file path
                if (!string.IsNullOrEmpty(varPrintTo))
                {
                    info.Arguments = "\"" + varPrintTo + "\"";
                }
                info.Verb = "PrintTo";
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                var process = Process.Start(info);
                process.WaitForExit();
                result = true;
            }
            catch (Exception ex)
            {
                Program.AddRTBText(rtbStatus, string.Format("{0:g} ", DateTime.Now) + " Unable to Print. Error: " + ex.Message, Color.Red);
            }
            return result;
        }

        public bool PrintPDF(string fileToPrint)
        {
            bool result = false;
            return result;
        }

        public bool PrintXLS(string fileToPrint)
        {
            bool result = false;
            return result;
        }
        public void LoadSettings()
        {
            String s = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "-CONFIG.XML";
            String appPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!Directory.Exists(Path.Combine(appPath, "Temp")))
            {
                try
                {
                    Directory.CreateDirectory(Path.Combine(appPath, "Temp"));

                }
                catch (IOException ex)
                {
                    DialogResult dr = new DialogResult();

                    dr = MessageBox.Show("Unable to Create Application Temp folder. Error was :" + ex.Message, "Creating System Folders", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Retry)
                    {

                    }

                }


            }
            Globals.TempPath = Path.Combine(appPath, "Temp");
            if (!Directory.Exists(Path.Combine(appPath, "Log")))
            {
                try
                {
                    Directory.CreateDirectory(Path.Combine(appPath, "Log"));

                }
                catch (IOException ex)
                {
                    DialogResult dr = new DialogResult();

                    dr = MessageBox.Show("Unable to Create Application Log folder. Error was :" + ex.Message, "Creating System Folders", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Retry)
                    {

                    }

                }
            }
            Globals.LogPath = Path.Combine(appPath, "Log");
            s = Path.Combine(appPath, s);
            tmrMain.Elapsed += new ElapsedEventHandler(tmrMain_Elapsed);
            XmlDocument xmlConfig = new XmlDocument();
            if (!File.Exists(s))
            {
                CreateConfigXML(s);
            }
            xmlConfig.Load(s);
            XmlNodeList nodelist;
            nodelist = xmlConfig.SelectNodes("/PopPrint/SystemSettings");
            XmlNode xmlProfileSettings = nodelist[0].SelectSingleNode("ProfileLocation");
            if (!String.IsNullOrEmpty(xmlProfileSettings.InnerText))
            {
                Globals.AppProfilePath = xmlProfileSettings.InnerText;
            }
            else
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (!Directory.Exists(Path.Combine(path, "POPPrint")))
                {
                    Directory.CreateDirectory(Path.Combine(path, "POPPrint"));

                }
                appPath = Path.Combine(path, "POPPrint");
                Globals.AppProfilePath = appPath;
                xmlProfileSettings.InnerText = appPath;
            }
            Globals.ProfileXml = Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml");
            XmlNode xmlTimer = nodelist[0].SelectSingleNode("/PopPrint/TimerInterval");
            if (xmlTimer != null)
            {
                Globals.TimerInt = Convert.ToInt16(xmlTimer.InnerText);
            }
            else
            {
                XmlNode timernode = xmlConfig.SelectSingleNode("/PopPrint");
                XmlElement timerElement = xmlConfig.CreateElement("TimerInterval");
                timernode.AppendChild(timerElement);
                timerElement.InnerText = "5";
                Globals.TimerInt = 5;
            }
            tmrMain.Interval = (Globals.TimerInt * 1000) * 60;

            nodelist = xmlConfig.SelectNodes("/PopPrint/ArchiveSettings");
            XmlNode xmlArchiveSettings = nodelist[0].SelectSingleNode("ArchiveFrequency");
            if (!String.IsNullOrEmpty(xmlArchiveSettings.InnerText))
            {
                Globals.ArcFrequency = xmlArchiveSettings.InnerText;
            }
            else
            {
                Globals.ArcFrequency = "Daily";
                xmlArchiveSettings.InnerText = "Daily";
            }
            xmlConfig.Save(s);
            if (!File.Exists(Globals.ProfileXml))
            {
                CreateProfileXML(Globals.ProfileXml);
            }
            try
            {
                dsProfiles.ReadXml(Globals.ProfileXml);
            }
            catch (IOException exIO)
            {
                //    MessageBox.Show("Missing Profile Location. Please locate file", "Error loading Profile XML", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    frmSysProfile systemSettings = new frmSysProfile();
                //    systemSettings.ShowDialog();
                //    LoadSettings();
                //
            }
            catch (Exception ex)
            {
                CreateProfileXML(Globals.ProfileXml);
            }
            dsProfiles.ReadXml(Globals.ProfileXml);
        }


        public void CreateProfileXML(string appprofilexml)
        {
            //First create the XDocument instance
            // Note that the Xdocument is created in one line. I have separated it to make it easier to read
            XDocument xmlProfileConf = new XDocument(
                new XDeclaration("1.0", "UTF-8", "Yes"),
                new XElement("Mailboxes",
                    new XElement("Mailbox",
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
                                        new XElement("FtpKeyPath"),
                                        new XElement("FtpFingerPrint"),

                                        new XElement("FtpSecure"),
                                        new XElement("FtpFolder")
                                                   ),
                        new XElement("PopServer"),
                        new XElement("PopUserName"),
                        new XElement("PopPassword"),
                        new XElement("PopPort"),
                        new XElement("PopSSL"),
                        new XElement("AddressTo")

                                     )));
            xmlProfileConf.Save(appprofilexml);
            LoadSettings();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "&Start")
            {
                ((Button)sender).Text = "&Stop";
                ((Button)sender).BackColor = Color.LightCoral;
                slStatus.Text = "Timed Processes Started";
                ProcessJobs();
                //  PrintJobs("");
                tmrMain.Start();

            }
            else
            {
                ((Button)sender).Text = "&Start";
                ((Button)sender).BackColor = Color.LightGreen;
                slStatus.Text = "Timed Processes Stopped";
            }
        }

        public void CreateConfigXML(string appconfigxml)
        {
            //First create the XDocument instance
            // Note that the Xdocument is created in one line. I have separated it to make it easier to read
            XDocument xmlSysConfig = new XDocument(
                new XDeclaration("1.0", "UTF-8", "Yes"),
                new XElement("PopPrint",
                new XElement("LogSettings",
                new XElement("LogLocation")),
                new XElement("SystemSettings",
                new XElement("ProfileLocation"),
                new XElement("AttachmentLocation")),
                new XElement("ArchiveSettings",
                new XElement("ArchiveFrequency")))
                );
            xmlSysConfig.Save(appconfigxml);
        }

        private void jobProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJobProfiles jobProfiles = new frmJobProfiles();
            jobProfiles.Show();
        }
    }
}

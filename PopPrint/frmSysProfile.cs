using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace PopPrint
{
    public partial class frmSysProfile : Form
    {
        public frmSysProfile()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = txtLogLocation.Text;
            fd.ShowDialog();
            txtLogLocation.Text = fd.SelectedPath;
        }

        private void btnProfileLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = txtProfileLocation.Text;
            fd.ShowDialog();
            txtProfileLocation.Text = fd.SelectedPath;
        }

        private void frmSysProfile_Load(object sender, EventArgs e)
        {
            switch (Globals.ArcFrequency)
            {
                case "Daily":
                    radDaily.Checked = true;
                    break;
                case "Weekly":
                    radWeekly.Checked = true;
                    break;
                case "Monthly":
                    radMonthly.Checked = true;
                    break;
            }
            txtLogLocation.Text = Globals.LogPath;
            txtProfileLocation.Text = Globals.AppProfilePath;
            txtTimer.Value = Globals.TimerInt;
            txtAttLocation.Text = Globals.AttachmentPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String s = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "-CONFIG.XML";
            String appPath = Path.GetDirectoryName(Application.ExecutablePath);
            s = Path.Combine(appPath, s);
            if (!File.Exists(s))
            {
                XDocument xmlConf = new XDocument(
                        new XDeclaration("1.0", "UTF-8", "Yes"),
                        new XElement("PopPrint",
                        new XElement("LogSettings",
                            new XElement("LogLocation")),
                        new XElement("SystemSettings",
                            new XElement("ProfileLocation"),
                            new XElement("AttachmentLocation")),
                        new XElement("ArchiveSettings",
                            new XElement("ArchiveFrequency"))));
                xmlConf.Save(s);
            }

            foreach (RadioButton rb in gbArchiveFreq.Controls)
            {
                switch (rb.Text)
                {
                    case "Daily":
                        if (radDaily.Checked)
                            Globals.ArcFrequency = "Daily";
                        break;
                    case "Weekly":
                        if (radWeekly.Checked)
                            Globals.ArcFrequency = "Weekly";
                        break;
                    case "Monthly":
                        if (radMonthly.Checked)
                            Globals.ArcFrequency = "Monthly";
                        break;
                }
            }
            XmlDocument xmlConfig = new XmlDocument();
            xmlConfig.Load(s);
            XmlNodeList nodelist = xmlConfig.SelectNodes("/PopPrint/LogSettings");
            XmlNode xmlLogLocation = nodelist[0].SelectSingleNode("LogLocation");
            XmlNode xnode;
            if (xmlLogLocation == null)
            {
                xnode = xmlConfig.CreateElement("LogLocation");
                xnode.InnerText = txtLogLocation.Text;
                nodelist[0].AppendChild(xnode);
            }
            else
            {
                xmlLogLocation.InnerText = txtLogLocation.Text;
            }
            nodelist = xmlConfig.SelectNodes("/PopPrint/SystemSettings");
            XmlNode xmlProfileLocation = nodelist[0].SelectSingleNode("ProfileLocation");
            if (xmlProfileLocation == null)
            {
                xnode = xmlConfig.CreateElement("ProfileLocation");
                xnode.InnerText = txtProfileLocation.Text;
                nodelist[0].AppendChild(xnode);
            }
            else
            {
                xmlProfileLocation.InnerText = txtProfileLocation.Text;
            }
            XmlNode xmlAttLocation = nodelist[0].SelectSingleNode("AttachmentLocation");
            if (xmlAttLocation == null)
            {
                xnode = xmlConfig.CreateElement("AttachmentLocation");
                xnode.InnerText = txtAttLocation.Text;
                nodelist[0].AppendChild(xnode);
            }
            else
            {
                xmlAttLocation.InnerText = txtAttLocation.Text;
            }
            nodelist = xmlConfig.SelectNodes("/PopPrint");
            
            XmlNode xmlTimer = nodelist[0].SelectSingleNode("TimerInterval");

            if (xmlTimer == null)
            {
                xnode = xmlConfig.CreateElement("TimerInterval");
                xnode.InnerText = txtTimer.Value.ToString();
            }
            else
            {
                xmlTimer.InnerText = txtTimer.Value.ToString();

            }

            nodelist = xmlConfig.SelectNodes("/PopPrint/ArchiveSettings");
            XmlNode xmlArchiveFreq = nodelist[0].SelectSingleNode("ArchiveFrequency");
            if (xmlArchiveFreq == null)
            {
                xnode = xmlConfig.CreateElement("ArchiveFrequency");
                xnode.InnerText = Globals.ArcFrequency;
                nodelist[0].AppendChild(xnode);
            }
            else
                xmlArchiveFreq.InnerText = Globals.ArcFrequency;


            xmlConfig.Save(s);

            Globals.AppProfilePath = txtProfileLocation.Text;
            Globals.LogPath = txtLogLocation.Text;
            Globals.TimerInt = (int)txtTimer.Value;
            MessageBox.Show("System Settings Saved");

        }

        private void txtProfileLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAttLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = txtAttLocation.Text;
            fd.ShowDialog();
            txtAttLocation.Text = fd.SelectedPath;
        }
    }
}


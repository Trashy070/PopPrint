using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PopPrint
{
    public partial class frmMain : Form
    {
        DataSet ds = new DataSet("ProfileXML");
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.Show();
            //settings.ShowDialog();
            //if (settings.DialogResult == DialogResult.OK)
            //{ }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Globals.AppProfilePath = Path.GetDirectoryName(Application.ExecutablePath);
            //ds.ReadXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
        }
    }
}

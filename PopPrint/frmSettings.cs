using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopPrint
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSysProfile_Click(object sender, EventArgs e)
        {
            frmSysProfile sysProfile = new frmSysProfile();
            sysProfile.Show();
        }

        private void btnJProfiles_Click(object sender, EventArgs e)
        {
            frmJobProfiles jobProfiles = new frmJobProfiles();
            jobProfiles.Show();
        }

        private void systemProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSysProfile_Click(sender,e);
        }

        private void jobProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnJProfiles_Click(sender, e);
        }
    }
}

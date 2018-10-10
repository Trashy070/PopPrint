using System;
using System.Windows.Forms;

namespace PopPrint
{
    public partial class frmTestEmail : Form
    {
        public frmTestEmail(string text)
        {
            InitializeComponent();
        }

        public frmTestEmail(string mailServer, string port, string username, string password, string ssl)
        {
            //This is an overloaded Constructor. It allows my to pass parameters and then initialise the component as normal.
            //I can then run a simple GetMail Test and return the results to the Text Box. 
            InitializeComponent();
            EmailTest(mailServer, port, username, password, ssl);


        }

        public void EmailTest(string mailServer, string port, string username, string password, string ssl)
        {
            bool isSSL = false;
            switch (ssl)
            {
                case "none":
                    isSSL = false;
                    break;
                default:
                    isSSL = true;
                    break;

            }
            txtTestResults.Text = MailModule.CheckMail(mailServer, Convert.ToInt32(port), isSSL, username, password);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

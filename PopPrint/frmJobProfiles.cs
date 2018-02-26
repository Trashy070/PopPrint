using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PopPrint
{
    public partial class frmJobProfiles : Form
    {
        public frmJobProfiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnArchiveLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = txtArchiveLocation.Text;
            folderBrowserDialog.ShowDialog();
            txtArchiveLocation.Text = folderBrowserDialog.SelectedPath;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
            //printDialog.PrinterSettings.PrinterName;
        }

        private void dgvJobProfileList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmJobProfiles_Load(object sender, EventArgs e)
        {
            GetPrinterList();
            GetProfileXMLData();
        }

        private void GetPrinterList()
        {
            String myInstalledPrinters;
            for (int p = 0; p < PrinterSettings.InstalledPrinters.Count; p++)
            {
                myInstalledPrinters = PrinterSettings.InstalledPrinters[p];
                cmbPrintList.Items.Add(myInstalledPrinters);
            }
        }

        private void GetProfileXMLData()
        {
            if (!File.Exists(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml")))
            {
                CreateProfileXML(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
            }
            else
            {
                dsJobProfiles.ReadXml(Path.Combine(Globals.AppProfilePath, "PopPrintProfiles.xml"));
                dgvJobProfileList.DataSource = dsJobProfiles;
                dgvJobProfileList.DataMember = dsJobProfiles.Tables[0].TableName;
            }
        }

        private void CreateProfileXML(string appprofilexml)
        {
            //First create the XDocument instance
            // Note that the Xdocument is created in one line. I have separated it to make it easier to read
            XDocument xmlProfileConf = new XDocument(
                new XDeclaration("1.0", "UTF-8", "Yes"),
                new XElement("Profiles",
                new XElement("Profile",
                new XElement("Name"),
                new XElement("PopServer"),
                new XElement("PopUserName"),
                new XElement("PopPassword"),
                new XElement("PopPort"),
                new XElement("PopSSL"),
                new XElement("PopAction"),
                new XElement("PopDelete"),
                new XElement("ArchiveFile"),
                new XElement("ArchiveLocation"),
                new XElement("PrintQueue")))
                );
            xmlProfileConf.Save(appprofilexml);
            GetProfileXMLData();
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
            ClearForm(this.Controls);
        }

        private void ClearForm(Control.ControlCollection controlCollection)
        {
            //This will recursively clear each TextBox and Set the ComboBox to the none selected option
            // Each control (ie the Form) is a container of Controls.
            // The Foreach loop checks each control if it is a Text Box or a Combobox and sets it. 
            // If the Control is another Container (ie Panel or Group Box) it will run the method again. 
            // These are called recursive loops. 
            foreach (var control in controlCollection)
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
                    ClearForm((ControlCollection)control);
                }

            }
        }


    }
}

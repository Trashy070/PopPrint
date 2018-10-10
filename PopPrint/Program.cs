using Ionic.Zip;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PopPrint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        static int GetWeekNumberOfMonth(DateTime date)
        {
            date = date.Date;
            DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
            DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            if (firstMonthMonday > date)
            {
                firstMonthDay = firstMonthDay.AddMonths(-1);
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            }
            return (date - firstMonthMonday).Days / 7 + 1;
        }

        public static String ArchiveFile(string arcPath, string fileName)
        {
            String archive = "";
            Boolean archived = false;
            String archiveName = "CTCNODE";
            switch (Globals.ArcFrequency)
            {
                case "Daily":
                    archiveName = DateTime.Now.ToString("ddd-dd-MM-yy");
                    break;
                case "Weekly":
                    archiveName = "Week-" + GetWeekNumberOfMonth(DateTime.Now).ToString() + String.Format("{0:MMMyyyy}", DateTime.Now);
                    break;
                case "Monthly":
                    archiveName = DateTime.Now.ToString("MMM-yyyy");
                    break;
            }

            try
            {

                if (!File.Exists(Path.Combine(arcPath, archiveName + ".ZIP")))
                {
                    using (ZipFile ZipNew = new ZipFile())
                    {
                        String newArchive = Path.Combine(arcPath, archiveName + ".ZIP");
                        ZipNew.AddFile(fileName, "");
                        ZipNew.Save(Path.Combine(newArchive));
                        archive = newArchive;
                        archived = true;
                        ZipNew.Dispose();

                    }
                }
                else
                {
                    var zipFile = ZipFile.Read(@Path.Combine(arcPath, archiveName + ".ZIP"));
                    var result = zipFile.Any(entry => entry.FileName.EndsWith(Path.GetFileName(fileName)));
                    zipFile.Dispose();
                    if (!(bool)result)
                    {
                        using (ZipFile Zip1 = ZipFile.Read(@Path.Combine(arcPath, archiveName + ".ZIP")))
                        {

                            try
                            {
                                Zip1.AddFile(fileName, "");
                                Zip1.Save(@Path.Combine(arcPath, archiveName + ".ZIP"));
                                Zip1.Save();
                                archive = Path.Combine(arcPath, archiveName + ".ZIP");
                                archived = true;
                            }
                            catch (Exception ex)
                            {

                            }
                            Zip1.Dispose();

                        }
                    }
                }
                //   File.Delete(fileName);
            }
            catch (Exception ex)
            {
            }

            return Path.GetFileName(archive);
        }

        public static void AddLabel(Label lb, string value)
        {
            if (lb.InvokeRequired)
            {
                lb.BeginInvoke(new Action(delegate { AddLabel(lb, value); }));
                return;
            }
            lb.Text = value;
        }

        public static void AddText(TextBox tb, string value)
        {
            if (tb.InvokeRequired)
            {
                tb.BeginInvoke(new Action(delegate { AddText(tb, value); }));
                return;
            }
            tb.AppendText(Environment.NewLine + value);

        }
        public static void AddRTBText(RichTextBox rtb, string value)
        {
            if (rtb.InvokeRequired)
            {
                rtb.BeginInvoke(new Action(delegate { AddRTBText(rtb, value); }));
                return;
            }

            rtb.AppendText((value) + Environment.NewLine);
            rtb.ScrollToCaret();

        }
        public static void AddRTBText(RichTextBox rtb, string value, Color color)
        {
            if (rtb.InvokeRequired)
            {
                rtb.BeginInvoke(new Action(delegate { AddRTBText(rtb, value, color); }));
                return;
            }
            string[] str = value.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            //rtb.AppendText(value);
            FontStyle fs = (FontStyle.Bold);
            rtb.DeselectAll();
            rtb.SelectionColor = color;
            rtb.AppendText(value + Environment.NewLine);
            rtb.SelectionFont = new Font(rtb.SelectionFont, FontStyle.Regular);
            rtb.SelectionColor = Color.Black;
            rtb.ScrollToCaret();

        }



    }
}

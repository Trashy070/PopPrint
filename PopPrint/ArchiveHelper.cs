using Ionic.Zip;
using System;
using System.IO;
using System.Linq;

namespace PopPrint
{
    class ArchiveHelper
    {
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
    }
}

using System.Collections.Generic;
using System.IO;

namespace PopPrint
{
    public class MsgSummary
    {
        public string MsgFrom
        {
            get;
            set;
        }
        public string MsgSubject
        {
            get;
            set;
        }
        public List<MsgAtt> MsgFile
        {
            get;
            set;
        }
        public string MsgStatus
        {
            get;
            set;
        }

        public int MsgId
        {
            get;
            set;
        }
    }

    public class ProfileMessage
    {
        public string ProfileName { get; set; }

        public string AddressFrom { get; set; }

        public string Subject { get; set; }

        public string FTPServer { get; set; }

        public string FTPPort { get; set; }

        public string FTPUser { get; set; }

        public string FTPPass { get; set; }

        public string FTPFolder { get; set; }

        public bool Secure { get; set; }

        public string Action { get; set; }

        public string ProfilePrinter { get; set; }
    }

    public class ProfileMailServer
    {
        public string Hostname { get; set; }

        public int Port { get; set; }

        public string SSL { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string AddressTo { get; set; }



    }


    public class MsgAtt
    {
        public FileInfo AttFilename
        {
            get;
            set;
        }
    }
    public class MailHelper
    {




    }
}

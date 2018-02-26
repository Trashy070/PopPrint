using System.Collections.Generic;
using System.IO;

namespace PopPrint
{
    class MailHelper
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
        }

        public class MsgAtt
        {
            public FileInfo AttFilename
            {
                get;
                set;
            }
        }
    }
}

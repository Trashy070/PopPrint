using PopPrint;
using System;
using System.IO;
using WinSCP;

public class PopPrintResources
{
    public static string FtpSend(string file, ProfileMessage message)
    {
        string Result = string.Empty;
        try
        {
            SessionOptions sessionOptions = new SessionOptions
            {
                HostName = message.FTPServer.Trim(),
                PortNumber = int.Parse(message.FTPPort),
                UserName = message.FTPUser.Trim(),
                Password = message.FTPUser.Trim()
            };
            if (message.FTPSsl)
            {
                sessionOptions.Protocol = Protocol.Sftp;

            }
            else
            {
                sessionOptions.Protocol = Protocol.Ftp;
            }
            //try
            //{
            TransferOperationResult tr;
            using (Session session = new Session())
            {
                session.Open(sessionOptions);
                if (session.Opened)
                {
                    //NodeResources.AddText(edLog, string.Format("{0:g} ", DateTime.Now) + " Connected to " + custProfile[0].P_server + ". Sending file  :" + xmlfile + Environment.NewLine + " TO " + sessionOptions.HostName + "/" + custProfile[0].P_path + "/" + Path.GetFileName(xmlfile));
                    TransferOptions tOptions = new TransferOptions();
                    tOptions.OverwriteMode = OverwriteMode.Overwrite;
                    tOptions.ResumeSupport.State = TransferResumeSupportState.Off;

                    if (string.IsNullOrEmpty(message.P_path))
                    {
                        message.P_path = "";
                    }
                    else
                    {
                        message.P_path = message.P_path + "/";
                    }
                    tr = session.PutFiles(file, "/" + message.P_path + Path.GetFileName(file), true, tOptions);
                    //NodeResources.AddText(edLog, string.Format("{0:g} ", DateTime.Now) + " Results: ");
                    if (tr.IsSuccess)
                    {
                        Result = "File Sent Ok";
                        try
                        {
                            File.Delete(file);
                        }
                        catch (Exception ex)
                        {
                            Result = "File Sent Ok. Delete Error: " + ex.Message;
                        }

                    }
                    else
                    {
                        Result = "Failed: Transfer Result is invalid: ";
                    }

                }
                else
                {

                }
            }

        }
        catch (Exception ex)
        {
            Result = "Failed: " + ex.GetType().Name + " " + ex.Message;
        }

        return Result;
    }

}


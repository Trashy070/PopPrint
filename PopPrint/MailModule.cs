using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Mail;
using static PopPrint.MailHelper;

namespace PopPrint
{
    class MailModule
    {


        public static List<MsgSummary> GetMail(string hostname, int port, bool useSsl, string username, string password)
        {
            int messageCount = 0;
            String fromMail = "";
            String subject = "";
            List<MsgSummary> allMessages = new List<MsgSummary>();
            Pop3Client client = new Pop3Client();
            try
            {
                client.Connect(hostname, port, useSsl);
                if (client.Connected)
                {
                    client.Authenticate(username, password);
                }
                messageCount = client.GetMessageCount();
                if (messageCount > 0)
                {

                    for (int i = messageCount; i > 0; i--)
                    {
                        if (client.GetMessage(i) != null)
                        {
                            OpenPop.Mime.Message msg = client.GetMessage(i);
                            MsgSummary newSumm = new MsgSummary();
                            try
                            {
                                if (msg.Headers.From.MailAddress.Address != null && msg.Headers.From.MailAddress.Address != "")
                                {
                                    fromMail = msg.Headers.From.MailAddress.Address;
                                }
                                if (msg.Headers.Subject != null && msg.Headers.Subject != "")
                                {
                                    subject = msg.Headers.Subject;
                                }
                                List<MsgAtt> att = new List<MsgAtt>();
                                foreach (OpenPop.Mime.MessagePart attach in msg.FindAllAttachments())
                                {
                                    string file_name_attach = attach.FileName;
                                    //TODO
                                    //FileInfo fi = new FileInfo(Path.Combine(Globals.CustomReceive, file_name_attach));
                                   // att.Add(new MsgAtt() { AttFilename = fi });
                                   // attach.Save(fi);
                                }
                                newSumm.MsgFile = att;
                                newSumm.MsgFrom = fromMail;
                                newSumm.MsgSubject = subject;
                                newSumm.MsgStatus = "Ok";
                                client.DeleteMessage(i);
                            }
                            catch (Exception exAtt)
                            {
                                newSumm.MsgStatus = exAtt.Message;

                            }
                            finally
                            {
                                allMessages.Add(newSumm);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MsgSummary newSumm = new MsgSummary();
                newSumm.MsgStatus = ex.Message;
                allMessages.Add(newSumm);
            }
            finally
            {
                try
                {
                    client.Disconnect();
                }
                catch (Exception ex)
                {

                }
            }
            return allMessages;

        }

        public static string CheckMail(string hostname, int port, bool useSsl, string username, string password)
        {
            string mailStatus = "";
            Pop3Client client = new Pop3Client();
            try
            {
                client.Connect(hostname, port, useSsl);
                if (client.Connected)
                {
                    mailStatus += "Server " + hostname + ":" + port.ToString() + ", Connected. Ok." + Environment.NewLine;
                    try
                    {

                        client.Authenticate(username, password);
                        mailStatus += "Username and Password details are Correct. Mail Connection Connected. Ok." + Environment.NewLine;
                    }
                    catch (Exception ex)
                    {
                        mailStatus += "Username and/or Password are incorrect. Please confirm the credentials" + Environment.NewLine;
                    }


                }
                else
                {
                    mailStatus += "Warning. Server " + hostname + ":" + port.ToString() + ", Not Connected. " + Environment.NewLine + "Please check server, port, SSL settings";
                }
            }
            catch (Exception ex)
            {
                mailStatus = ex.Message;
            }
            finally
            {
                try
                {
                    client.Disconnect();
                    mailStatus += "Server disconnected." + Environment.NewLine;
                }
                catch (Exception ex)
                {

                }
            }
            return mailStatus;


        }

        static bool mailSent = false;

        public static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                Console.WriteLine("Message sent.");
            }
            mailSent = true;
        }

        public static String sendMsg(String file, String to, String mySubject, String msg)
        {
            SmtpClient myMail = new SmtpClient();
            //TODO

            //myMail.Host = SMTPServer.Server;
            //myMail.Port = Convert.ToInt16(SMTPServer.Port);
            //myMail.EnableSsl = ssl;
            //myMail.Credentials = new System.Net.NetworkCredential(SMTPServer.Username, SMTPServer.Password);
            myMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage myMsg = new MailMessage();
            myMsg.To.Add(new System.Net.Mail.MailAddress(to));
            if (file != "")
            {
                try
                {
                    if (File.Exists(file))
                    {
                        myMsg.Attachments.Add(new System.Net.Mail.Attachment(file));

                    }
                }
                catch (Exception ex)
                {
                 //   sendMsg("", Globals.AlertsTo, "Error Sending Alert Email", "Error Message is: " + ex.Message + Environment.NewLine + "Original Message to send was: " + Environment.NewLine + msg);
                }
            }
          //  myMsg.From = new System.Net.Mail.MailAddress(SMTPServer.Email, "CTC Adapter");
            myMsg.Subject = mySubject;
            myMsg.Body = msg;
            myMail.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            //String userState = "Send from CTCNODE";
            try
            {
                myMail.Send(myMsg);
                myMsg.Dispose();
                myMail.Dispose();

                return "Message Sent OK";
            }
            catch (Exception ex)
            {
                myMsg.Dispose();
                myMail.Dispose();
                return "Message failed to send. Error was: " + ex.Message;
            }
        }


    }
}

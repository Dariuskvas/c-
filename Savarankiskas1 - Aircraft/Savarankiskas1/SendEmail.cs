using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas1
{
    public class SendEmail
    {
        public void sendEmail()
        {
            String SendMailFrom = "darius.kvasauskas@gmail.com";
            String SendMailTo = "darius.kvasauskas@gmail.com";
            String SendMailSubject = "Plane report";
            String SendMailBody = "Plane report about plane";

            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage email = new MailMessage();
                // START
                email.From = new MailAddress(SendMailFrom);
                email.To.Add(SendMailTo);
                email.CC.Add(SendMailFrom);
                email.Subject = SendMailSubject;
                email.Body = SendMailBody;

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(@"C:\Users\Darius\Desktop\PlaneReport2.html");
                email.Attachments.Add(attachment);
                
                //END
                SmtpServer.Timeout = 5000;
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new NetworkCredential(SendMailFrom, "robxtdftxixixzpk");
                SmtpServer.Send(email);

                Console.WriteLine("Email Successfully Sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}

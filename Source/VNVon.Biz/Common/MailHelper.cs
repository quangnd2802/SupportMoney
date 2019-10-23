using System.Net;
using System.Net.Mail;

namespace VNVon.Service.Common
{
    public class MailHelper
    {
        public static void SendMail(string to, string displayName, string subject, string content)
        {
            using (var message = new MailMessage())
            {
                message.From = new MailAddress("le.hong.quang1608@gmail.com", "VN VON System.");
                message.To.Add(new MailAddress(to, displayName));
                message.Subject = subject;
                message.Body = content;
                message.IsBodyHtml = true;

                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.Credentials = new NetworkCredential("le.hong.quang1608@gmail.com", "nhatminh2014");
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }
        }
    }
}

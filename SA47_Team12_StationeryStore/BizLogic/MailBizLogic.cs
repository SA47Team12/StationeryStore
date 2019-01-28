using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace SA47_Team12_StationeryStore.BizLogic
{
    public class MailBizLogic
    {
        public static void sendMail(String from, String to, String subject, String body)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Subject = subject;
            mailMessage.Body = body;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "teststationery47@gmail.com",
                Password = "rFEq8D6UnwV9"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);

        }
    }
}
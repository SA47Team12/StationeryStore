using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace SA47_Team12_StationeryStore
{
    public class ScheduleEmail
    {
        private List<CatalogueInventoryViewModel> listOfLowStockItems;

        public ScheduleEmail()
        { }

        public void SendScheduleMail(List<CatalogueInventoryViewModel> list) // argument: List<CatalogueInventoryViewModel> list
        {
            // Write your send mail code here.

            //configure smtpClient
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "teststationery47@gmail.com",
                Password = "rFEq8D6UnwV9"
            };

            foreach (CatalogueInventoryViewModel c in list)
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add("teststationery47@gmail.com");
                mailMessage.From = new MailAddress("teststationery47@gmail.com");
                mailMessage.Subject = String.Format("Item {0} is low in stock - {1}", c.ItemID, c.ItemDescription);
                mailMessage.Body = String.Format(" Item {0} is low in stock - {1}", c.ItemID, c.ItemDescription);

                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
            }
        }

        public void SendScheduleMail(List<UserRepCollection> list) // argument: List<CatalogueInventoryViewModel> list
        {
            // Write your send mail code here.

            //configure smtpClient
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "teststationery47@gmail.com",
                Password = "rFEq8D6UnwV9"
            };

            //foreach (CatalogueInventoryViewModel c in list)
            //{
            //    MailMessage mailMessage = new MailMessage();
            //    mailMessage.To.Add("teststationery47@gmail.com");
            //    mailMessage.From = new MailAddress("teststationery47@gmail.com");
            //    mailMessage.Subject = String.Format("Item {0} is low in stock - {1}", c.ItemNo, c.ItemDescription);
            //    mailMessage.Body = String.Format(" Item {0} is low in stock - {1}", c.ItemNo, c.ItemDescription);

            //    smtpClient.EnableSsl = true;
            //    smtpClient.Send(mailMessage);
            //}
        }
    }
}
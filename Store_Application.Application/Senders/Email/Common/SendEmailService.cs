using System;
using System.Net;
using System.Net.Mail;
using DnsClient;

namespace Store_Application.Application.Senders.Email.Common
{
    public class SendEmailService : ISendEmailService
    {
        public void SendEmail(RequestSendEmailDto req)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("mahdi.np1232589870@gmail.com");
            message.To.Add(new MailAddress(req.To));
            message.Subject = req.Subject;
            message.IsBodyHtml = true;
            message.Body = req.Body;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("mahdi.np1232589870@gmail.com", "0X6d616864692e6e70");
            
            try
            {
                smtp.Send(message);
            }
            catch (SmtpException e)
            {

            }

        }
    }
}

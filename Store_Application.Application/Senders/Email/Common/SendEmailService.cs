using System.Net;
using System.Net.Mail;

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
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = req.Body;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("mahdi.np1232589870@gmail.com", "0x6d616864692e6e70");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }
    }
}

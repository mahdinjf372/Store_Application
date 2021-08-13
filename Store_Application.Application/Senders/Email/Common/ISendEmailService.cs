namespace Store_Application.Application.Senders.Email.Common
{
    public interface ISendEmailService
    {
        void SendEmail(RequestSendEmailDto req);
    }
}

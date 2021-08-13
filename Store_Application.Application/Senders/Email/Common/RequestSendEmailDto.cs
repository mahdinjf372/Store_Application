namespace Store_Application.Application.Senders.Email.Common
{
    public class RequestSendEmailDto
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}

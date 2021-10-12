using System;

namespace Store_Application.Application.Services.SiteRequest.Commands.AddRequest
{
    public class RequestAddRequestDto
    {
        public string Ip { get; set; }
        public bool HasFormContentType { get; set; }
        public bool HasJsonContentType { get; set; }
        public bool IsHttps { get; set; }
        public string Methode { get; set; }
        public string Path { get; set; }
        public bool IsAuthenticated { get; set; }
        public int? UserId { get; set; }
        public Guid? BrowserId { get; set; }
    }
}

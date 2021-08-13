using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Senders.Email.Common;
using Store_Application.Application.Services.Users.Queries.GetUserByEmail;
using Store_Application.Common.Setting;
using Store_Application.Common.ViewModels;
using System.IO;

namespace Store_Application.Application.Senders.Email.ActivationCode
{
    public class SendActivationLinkEmailService : ISendActivationLinkEmailService
    {
        private ISendEmailService _sendEmailService;
        public SendActivationLinkEmailService(ISendEmailService sendEmailService)
        {
            _sendEmailService = sendEmailService;
        }

        public ResultDto Execute(string email, string activationCode, string username)
        {

            string path =
                Path.Combine(Directory.GetCurrentDirectory() + "/Views/Authentication/ActivationEmail.html");

            string Body = File.ReadAllText(path).Replace("{name}", username)
                .Replace("{href}", $"{SiteSetting.SiteDomain}/Authentication/ActiveUser/{activationCode}");

            string subject = "ایمیل فعال سازی";

            _sendEmailService.SendEmail(new RequestSendEmailDto {To=email,Body=Body,Subject= subject});

            return new ResultDto
            {
                IsSuccess = true,
                Message = "ایمیل فعالسازی با موفقیت ارسال شد"
            };
        }
    }
}

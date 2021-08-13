using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Senders.Email.Common;
using Store_Application.Application.Services.Users.Queries.GetActivationCodeByEmail;
using Store_Application.Common.Setting;
using Store_Application.Common.ViewModels;
using System.IO;

namespace Store_Application.Application.Senders.Email.ChangePassword
{
    public class SendChangePasswordLinkService : ISendChangePasswordLinkService
    {
        private ISendEmailService _sendEmailService;
        private IUserFacad _userFacad;
        public SendChangePasswordLinkService(ISendEmailService sendEmailService, IUserFacad userFacad)
        {
            _sendEmailService = sendEmailService;
            _userFacad = userFacad;
        }

        public ResultDto Execute(string email)
        {
            var res = _userFacad.GetActivationCodeByEmailService.Execute(email);

            if (res.IsSuccess)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory() +
                                "/Views/Authentication/ChangePasswordEmail.html");
                var body = File.ReadAllText(path).Replace("{href}", SiteSetting.SiteDomain + "/PasswordRecovery/?id=" + res.Data);
                var subject = "ایمیل بازیابی رمز عبور";

                _sendEmailService.SendEmail(new RequestSendEmailDto { Body = body, Subject = subject, To = email });
                
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "ارسال ایمیل بازیابی با موفقیت انجام شد"
                };
            }

            return new ResultDto
            {
                IsSuccess = false,
                Message = "ارسال ایمیل بازیابی با شکست مواجه شد"
            };

        }
    }
 
}

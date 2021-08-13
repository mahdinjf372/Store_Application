using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Senders.Email.ActivationCode
{
    public interface ISendActivationLinkEmailService
    {
        ResultDto Execute(string email,string activationCode, string username);
    }
}

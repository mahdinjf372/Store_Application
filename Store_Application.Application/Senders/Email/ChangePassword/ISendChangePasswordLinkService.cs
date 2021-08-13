using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Senders.Email.ChangePassword
{
    public interface ISendChangePasswordLinkService
    {
        ResultDto Execute(string email);
    }

}

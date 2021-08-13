using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Users.Commands.RemoveUser
{
    public interface IRemoveUserService
    {
        ResultDto Execute(int userId);
    }
}

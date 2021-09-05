using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Users.Commands.RemoveUserForAdmin
{
    public interface IRemoveUserForAdminService
    {
        ResultDto Execute(int userId);
    }
}

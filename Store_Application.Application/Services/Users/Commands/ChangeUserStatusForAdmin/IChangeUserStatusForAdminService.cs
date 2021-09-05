using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Users.Commands.ChangeUserStatusForAdmin
{
    public interface IChangeUserStatusForAdminService
    {
        ResultDto<bool> Execute(int userId);
    }
}

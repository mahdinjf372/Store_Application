using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Users.Commands.ChangeUserStatus
{
    public interface IChangeUserStatusService
    {
        ResultDto<bool> Execute(int userId);
    }
}

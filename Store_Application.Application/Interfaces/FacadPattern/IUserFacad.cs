using Store_Application.Application.Services.Users.Commands.ActiveUser;
using Store_Application.Application.Services.Users.Commands.ChangeUserStatusForAdmin;
using Store_Application.Application.Services.Users.Commands.EditUserForAdmin;
using Store_Application.Application.Services.Users.Commands.RecoveryPasswordByActivationCode;
using Store_Application.Application.Services.Users.Commands.RegisterUserForAdmin;
using Store_Application.Application.Services.Users.Commands.RemoveUserForAdmin;
using Store_Application.Application.Services.Users.Queries.GetActivationCodeByEmail;
using Store_Application.Application.Services.Users.Queries.GetRolesForAdmin;
using Store_Application.Application.Services.Users.Queries.GetUserByEmail;
using Store_Application.Application.Services.Users.Queries.GetUserByIdForAdmin;
using Store_Application.Application.Services.Users.Queries.GetUsersForAdmin;
using Store_Application.Application.Services.Users.Queries.IsExistActiveCode;
using Store_Application.Application.Services.Users.Queries.IsExistEmail;
using Store_Application.Application.Services.Users.Queries.IsExistRoleForAdmin;
using Store_Application.Application.Services.Users.Queries.IsExistUserForAdmin;
using Store_Application.Application.Services.Users.Queries.LoginUser;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IUserFacad
    {
        IActiveUserService ActiveUserService { get; }
        IChangeUserStatusForAdminService ChangeUserStatusForAdminService { get; }
        IEditUserForAdminService EditUserForAdminService { get; }
        IRecoveryPasswordByActivationCodeService RecoveryPasswordByActivationCodeService { get; }
        IRegisterUserForAdminService RegisterUserForAdminService { get; }
        IRemoveUserForAdminService RemoveUserForAdminService { get; }
        IGetActivationCodeByEmailService GetActivationCodeByEmailService { get; }
        IGetRolesForAdminService GetRolesForAdminService { get; }
        IGetUserByEmailService GetUserByEmailService { get; }
        IGetUserByIdForAdminService GetUserByIdForAdminService { get; }
        IGetUsersForAdminService GetUsersForAdminService { get; }
        IisExistActiveCodeService isExistActiveCodeService { get; }
        IisExistEmailService isExistEmailService { get; }
        IisExistRoleForAdminService isExistRoleForAdminService { get; }
        IisExistUserForAdminService isExistUserForAdminService { get; }
        ILoginUserService LoginUserService { get; }

    }
}

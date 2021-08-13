using Store_Application.Application.Services.Users.Commands.ActiveUser;
using Store_Application.Application.Services.Users.Commands.ChangeUserStatus;
using Store_Application.Application.Services.Users.Commands.EditUser;
using Store_Application.Application.Services.Users.Commands.RecoveryPasswordByActivationCode;
using Store_Application.Application.Services.Users.Commands.RegisterUser;
using Store_Application.Application.Services.Users.Commands.RemoveUser;
using Store_Application.Application.Services.Users.Queries.GetActivationCodeByEmail;
using Store_Application.Application.Services.Users.Queries.GetRoles;
using Store_Application.Application.Services.Users.Queries.GetUserByEmail;
using Store_Application.Application.Services.Users.Queries.GetUserById;
using Store_Application.Application.Services.Users.Queries.GetUsers;
using Store_Application.Application.Services.Users.Queries.IsExistActiveCode;
using Store_Application.Application.Services.Users.Queries.IsExistEmail;
using Store_Application.Application.Services.Users.Queries.IsExistRole;
using Store_Application.Application.Services.Users.Queries.IsExistUser;
using Store_Application.Application.Services.Users.Queries.LoginUser;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IUserFacad
    {
        IActiveUserService ActiveUserService { get; }
        IChangeUserStatusService ChangeUserStatusService { get; }
        IEditUserService EditUserService { get; }
        IRecoveryPasswordByActivationCodeService RecoveryPasswordByActivationCodeService { get; }
        IRegisterUserService RegisterUserService { get; }
        IRemoveUserService RemoveUserService { get; }
        IGetActivationCodeByEmailService GetActivationCodeByEmailService { get; }
        IGetRolesService GetRolesService { get; }
        IGetUserByEmailService GetUserByEmailService { get; }
        IGetUserByIdService GetUserByIdService { get; }
        IGetUsersService GetUsersService { get; }
        IisExistActiveCodeService isExistActiveCodeService { get; }
        IisExistEmailService isExistEmailService { get; }
        IisExistRoleService isExistRoleService { get; }
        IisExistUserService isExistUserService { get; }
        ILoginUserService LoginUserService { get; }

    }
}

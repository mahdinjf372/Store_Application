using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Senders.Email.ActivationCode;
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

namespace Store_Application.Application.Services.Users.FacadPattern
{
    public class UserFacad : IUserFacad
    {
        private readonly IDataBaseContext _db;
        private ISendActivationLinkEmailService _sendActivationLinkEmailService;
        public UserFacad(IDataBaseContext db, ISendActivationLinkEmailService sendActivationLinkEmailService)
        {
            _db = db;
            _sendActivationLinkEmailService = sendActivationLinkEmailService;
        }


        private IActiveUserService _activeUserService;
        public IActiveUserService ActiveUserService
        {
            get
            {
                return _activeUserService = _activeUserService ?? new ActiveUserService(_db);
            }
        }


        private IChangeUserStatusForAdminService _changeUserStatusForAdminService;
        public IChangeUserStatusForAdminService ChangeUserStatusForAdminService
        {
            get
            {
                return _changeUserStatusForAdminService = _changeUserStatusForAdminService ?? new ChangeUserStatusForAdminService(_db);
            }
        }


        private IEditUserForAdminService _editUserForAdminService;
        public IEditUserForAdminService EditUserForAdminService
        {
            get
            {
                return _editUserForAdminService = _editUserForAdminService ?? new EditUserForAdminService(_db);
            }
        }


        private IRecoveryPasswordByActivationCodeService _recoveryPasswordByActivationCodeService;
        public IRecoveryPasswordByActivationCodeService RecoveryPasswordByActivationCodeService
        {
            get
            {
                return _recoveryPasswordByActivationCodeService = _recoveryPasswordByActivationCodeService ?? new RecoveryPasswordByActivationCodeService(_db);
            }
        }


        private IRegisterUserForAdminService _registerUserForAdminService;
        public IRegisterUserForAdminService RegisterUserForAdminService
        {
            get
            {
                return _registerUserForAdminService = _registerUserForAdminService ?? new RegisterUserForAdminService(_db, _sendActivationLinkEmailService);
            }
        }


        private IRemoveUserForAdminService _removeUserForAdminService;
        public IRemoveUserForAdminService RemoveUserForAdminService
        {
            get
            {
                return _removeUserForAdminService = _removeUserForAdminService ?? new RemoveUserForAdminService(_db);
            }
        }


        private IGetActivationCodeByEmailService _getActivationCodeByEmailService;
        public IGetActivationCodeByEmailService GetActivationCodeByEmailService
        {
            get
            {
                return _getActivationCodeByEmailService = _getActivationCodeByEmailService ?? new GetActivationCodeByEmailService(_db);
            }
        }


        private IGetRolesForAdminService _getRolesForAdminService;
        public IGetRolesForAdminService GetRolesForAdminService
        {
            get
            {
                return _getRolesForAdminService = _getRolesForAdminService ?? new GetRolesForAdminService(_db);
            }
        }


        private IGetUserByEmailService _getUserByEmailService;
        public IGetUserByEmailService GetUserByEmailService
        {
            get
            {
                return _getUserByEmailService = _getUserByEmailService ?? new GetUserByEmailService(_db);
            }
        }


        private IGetUserByIdForAdminService _getUserByIdForAdminService;
        public IGetUserByIdForAdminService GetUserByIdForAdminService
        {
            get
            {
                return _getUserByIdForAdminService = _getUserByIdForAdminService ?? new GetUserByIdForAdminService(_db);
            }
        }


        private IGetUsersForAdminService _getUsersForAdminService;
        public IGetUsersForAdminService GetUsersForAdminService
        {
            get
            {
                return _getUsersForAdminService = _getUsersForAdminService ?? new GetUsersForAdminService(_db);
            }
        }


        private IisExistActiveCodeService _isExistActiveCodeService;
        public IisExistActiveCodeService isExistActiveCodeService
        {
            get
            {
                return _isExistActiveCodeService = _isExistActiveCodeService ?? new isExistActiveCodeService(_db);
            }
        }


        private IisExistEmailService _isExistEmailService;
        public IisExistEmailService isExistEmailService
        {
            get
            {
                return _isExistEmailService = _isExistEmailService ?? new isExistEmailService(_db);
            }
        }


        private IisExistRoleForAdminService _isExistRoleForAdminService;
        public IisExistRoleForAdminService isExistRoleForAdminService
        {
            get
            {
                return _isExistRoleForAdminService = _isExistRoleForAdminService ?? new isExistRoleForAdminService(_db);
            }
        }


        private IisExistUserForAdminService _isExistUserForAdminService;
        public IisExistUserForAdminService isExistUserForAdminService
        {
            get
            {
                return _isExistUserForAdminService = _isExistUserForAdminService ?? new isExistUserForAdminService(_db);
            }
        }


        private ILoginUserService _loginUserService;
        public ILoginUserService LoginUserService
        {
            get
            {
                return _loginUserService = _loginUserService ?? new LoginUserService(_db);
            }
        }



    }
}

using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Senders.Email.ActivationCode;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        private IChangeUserStatusService _changeUserStatusService;
        public IChangeUserStatusService ChangeUserStatusService
        {
            get
            {
                return _changeUserStatusService = _changeUserStatusService ?? new ChangeUserStatusService(_db);
            }
        }


        private IEditUserService _editUserService;
        public IEditUserService EditUserService
        {
            get
            {
                return _editUserService = _editUserService ?? new EditUserService(_db);
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


        private IRegisterUserService _registerUserService;
        public IRegisterUserService RegisterUserService
        {
            get
            {
                return _registerUserService = _registerUserService ?? new RegisterUserService(_db, _sendActivationLinkEmailService);
            }
        }


        private IRemoveUserService _removeUserService;
        public IRemoveUserService RemoveUserService
        {
            get
            {
                return _removeUserService = _removeUserService ?? new RemoveUserService(_db);
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


        private IGetRolesService _getRolesService;
        public IGetRolesService GetRolesService
        {
            get
            {
                return _getRolesService = _getRolesService ?? new GetRolesService(_db);
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


        private IGetUserByIdService _getUserByIdService;
        public IGetUserByIdService GetUserByIdService
        {
            get
            {
                return _getUserByIdService = _getUserByIdService ?? new GetUserByIdService(_db);
            }
        }


        private IGetUsersService _getUsersService;
        public IGetUsersService GetUsersService
        {
            get
            {
                return _getUsersService = _getUsersService ?? new GetUsersService(_db);
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


        private IisExistRoleService _isExistRoleService;
        public IisExistRoleService isExistRoleService
        {
            get
            {
                return _isExistRoleService = _isExistRoleService ?? new isExistRoleService(_db);
            }
        }


        private IisExistUserService _isExistUserService;
        public IisExistUserService isExistUserService
        {
            get
            {
                return _isExistUserService = _isExistUserService ?? new isExistUserService(_db);
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

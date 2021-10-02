using EndPoint.WebSite.Models.Authentication.Login;
using EndPoint.WebSite.Models.Authentication.PasswordForget;
using EndPoint.WebSite.Models.Authentication.PasswordRecovery;
using EndPoint.WebSite.Models.Authentication.Register;
using EndPoint.WebSite.Utilities;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Senders.Email.ChangePassword;
using Store_Application.Application.Services.Users.Commands.RegisterUserForAdmin;
using Store_Application.Application.Services.Users.Queries.LoginUser;
using Store_Application.Domain.Enums;
using System.Collections.Generic;
using System.Security.Claims;

namespace EndPoint.WebSite.Controllers
{
    public class AuthenticationController : Controller
    {
        private ISendChangePasswordLinkService _sendChangePasswordLinkService;
        private readonly IUserFacad _userFacad;
        private readonly IFavoriteFacad _favoriteFacad;
        private readonly CookiesManager _cookiesManager;

        public AuthenticationController(
            ISendChangePasswordLinkService sendChangePasswordLinkService,
            IUserFacad userFacad,
            IFavoriteFacad favoriteFacad,
            CookiesManager cookiesManager)
        {
            _sendChangePasswordLinkService = sendChangePasswordLinkService;
            _userFacad = userFacad;
            _favoriteFacad = favoriteFacad;
            _cookiesManager = cookiesManager;
        }


        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel req)
        {
            var RequestValidator = new RegisterViewModelValidator();
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            if (!Validator.IsValid)
            {
                return View(req);
            }

            var dbRes = _userFacad.RegisterUserForAdminService.Execute(new RequestRegisterUserForAdminDto
            {
                Email = req.Email,
                Password = req.Password,
                Roles = new List<RegisterRoleDto>
                {
                    new RegisterRoleDto
                    {
                        Id = (int)Roles.Customer
                    }
                },
                Username = req.Username
            });

            if (!dbRes.IsSuccess)
            {
                if (dbRes.Message.Equals("این ایمیل قبلا ثبت شده است"))
                {
                    Validator.Errors.Add(new ValidationFailure("Email", dbRes.Message));
                    Validator.AddToModelState(ModelState, null);
                    return View(req);
                }
                else
                {
                    return View("/Views/Authentication/RegisterResultMessage.cshtml", req);
                }
            }

            return View("/Views/Authentication/RegisterResultMessage.cshtml", req);
        }

        [Route("ActiveUser/{activationCode}")]
        public IActionResult ActiveUser(string activationCode)
        {
            var res = _userFacad.isExistActiveCodeService.Execute(activationCode).Data;
            if (!res)
            {
                return View("ActivationMessage", res);
            }

            res = _userFacad.ActiveUserService.Execute(activationCode).IsSuccess;
            return View("ActivationMessage", res);
        }

        #endregion

        #region Login

        [Route("Login")]
        public IActionResult Login(string returnUrl = "/")
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel req, string returnUrl = "/")
        {
            var RequestValidator = new LoginViewModelValidator();
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            ViewBag.ReturnUrl = returnUrl;

            if (!Validator.IsValid)
            {
                return View(req);
            }

            ResultLoginUserDto user = _userFacad.LoginUserService.Execute(new RequestLoginUserDto()
            {
                Email = req.Email,
                Password = req.Password
            }).Data;

            if (user == null)
            {
                ViewBag.IncorrectInformation = true;
                return View(req);
            }

            if (!user.isActive)
            {
                ViewBag.IsAccountActive = false;
                return View(req);
            }


            List<Claim> Claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
            };

            foreach (var role in user.Roles)
            {
                Claims.Add(new Claim(ClaimTypes.Role, role.Name));
            }

            ClaimsIdentity identity = new ClaimsIdentity(Claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            AuthenticationProperties properties = new AuthenticationProperties()
            {
                IsPersistent = req.RememberMe
            };

            HttpContext.SignInAsync(principal, properties);

            _favoriteFacad.MergeFavoriteListService.Execute(user.Id,_cookiesManager.GetBrowserId(HttpContext));

            return Redirect(returnUrl);
        }

        [Route("LogOut")]
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/");
        }

        #endregion

        #region Password Recovery

        [Route("PasswordForget")]
        public IActionResult PasswordForget()
        {
            return View();
        }

        [HttpPost]
        [Route("PasswordForget")]
        public IActionResult PasswordForget(PasswordForgetViewModel req)
        {
            var RequestValidator = new PasswordForgetViewModelValidator();
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            if (!ModelState.IsValid)
                return View(req);

            if (!_userFacad.isExistEmailService.Execute(req.Email).Data)
            {
                Validator.Errors.Add(new ValidationFailure("Email", "کاربری با این مشخصات یافت نشد"));
                Validator.AddToModelState(ModelState, null);
                return View(req);
            }

            bool res = _sendChangePasswordLinkService.Execute(req.Email).IsSuccess;
            ViewBag.isSend = res;

            return View("/Views/Authentication/SuccessSendRecoveryPasswordEmailMessage.cshtml", req);
        }


        [Route("PasswordRecovery")]
        public IActionResult PasswordRecovery(string id)
        {
            if (!_userFacad.isExistActiveCodeService.Execute(id).Data)
                return View("/Views/Authentication/ExpiredActivationCodeMessage.cshtml");

            ViewBag.ActiveCode = id;
            return View();
        }

        [Route("PasswordRecovery")]
        [HttpPost]
        public IActionResult PasswordRecovery(RecoveryPasswordViewModel req)
        {
            var RequestValidator = new RecoveryPasswordViewModelValidator();
            var Validator = RequestValidator.Validate(req);

            ViewBag.ActiveCode = req.ActivationCode;

            if (string.IsNullOrEmpty(req.ActivationCode) || !_userFacad.isExistActiveCodeService.Execute(req.ActivationCode).Data)
            {
                Validator.Errors.Add(new ValidationFailure("Password", "کد فعالسازی شما منقضی شده"));
            }

            Validator.AddToModelState(ModelState, null);

            if (!Validator.IsValid)
            {
                return View(req);
            }

            _userFacad.RecoveryPasswordByActivationCodeService.Execute(req.ActivationCode, req.Password);

            return View("/Views/Authentication/SuccessChangePasswordMessage.cshtml");
        }
        #endregion

        #region AccessDenied

        [Route("AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }

        #endregion
    }
}

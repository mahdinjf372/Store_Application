using EndPoint.WebSite.Areas.UserPanel.Models.Account.EditAccountInformation;
using EndPoint.WebSite.Areas.UserPanel.Models.Account.Index;
using EndPoint.WebSite.Areas.UserPanel.Models.Account.ChangePassword;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Users.Commands.EditUserForUserPanel;
using System.Security.Claims;
using Store_Application.Application.Services.Users.Commands.ChangePasswordForUserPanel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using EndPoint.WebSite.Utilities;
using Store_Application.Domain.Enums;
using AutoMapper;

namespace EndPoint.WebSite.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class AccountController : Controller
    {
        private IUserFacad _userFacad;
        private readonly ClaimUtility _claimUtility;
        private readonly IMapper _mapper;

        public AccountController(IUserFacad userFacad, ClaimUtility claimUtility, IMapper mapper)
        {
            _claimUtility = claimUtility;
            _userFacad = userFacad;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            int userId = _claimUtility.GetUserId(User);
            var user = _userFacad.GetUserByIdForUserPanelService.Execute(userId);
            UserPanelViewModel model = _mapper.Map<UserPanelViewModel>(user.Data);
            
            ViewBag.ProfileIsActived = "active";

            return View(model);
        }

        #region Edit Account Information

        [HttpGet]
        public IActionResult EditAccountInformation()
        {
            int userId = _claimUtility.GetUserId(User);
            var user = _userFacad.GetUserByIdForUserPanelService.Execute(userId).Data;
            EditAccountInformationViewModel model = new EditAccountInformationViewModel()
            {
                Address = user.Address,
                Age = user.age,
                FullName = user.FullName,
                Phone = user.Phone
            };
            ViewBag.EditInfoIsActived = "active";
            return View(model);
        }

        [HttpPost]
        public IActionResult EditAccountInformation(EditAccountInformationViewModel req)
        {
            var RequestValidator = new EditAccountInformationViewModelValidator();
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            if (!ModelState.IsValid)
            {
                return View(req);
            }

            var userId = _claimUtility.GetUserId(User);
            _userFacad.EditUserForUserPanelService.Execute(new RequestEditUserForUserPanelDto
            {
                Id = userId,
                FullName = req.FullName,
                age = req.Age,
                Address = req.Address,
                Phone = req.Phone
            });

            return Redirect("Index");
        }

        #endregion

        #region Change Password
        [HttpGet]
        public IActionResult ChangePassword()
        {
            ViewBag.EditInfoIsActived = "active";
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel req)
        {
            var RequestValidator = new ChangePasswordViewModelValidator();
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            if (!ModelState.IsValid)
                return View(req);

            int userId = _claimUtility.GetUserId(User);
            bool IsOldPassword = _userFacad.IsOldPasswordService.Execute(userId, req.OldPassword).Data;
            if (!IsOldPassword)
            {
                ModelState.AddModelError("OldPassword", "رمز عبور فعلی نادرست است");
                return View(req);
            }

            _userFacad.ChangePasswordForUserPanelService.Execute(new RequestChangePasswordForUserPanelDto() { Id = userId, Password = req.Password });

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View("ChangePasswordMessage");
        }

        #endregion
    }
}

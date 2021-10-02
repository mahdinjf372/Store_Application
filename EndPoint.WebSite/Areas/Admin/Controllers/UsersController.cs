using EndPoint.WebSite.Areas.Admin.Models.Common;
using EndPoint.WebSite.Areas.Admin.Models.Users.EditUser;
using EndPoint.WebSite.Areas.Admin.Models.Users.LoadUsers;
using EndPoint.WebSite.Areas.Admin.Models.Users.RegisterUser;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Users.Commands.EditUserForAdmin;
using Store_Application.Application.Services.Users.Commands.RegisterUserForAdmin;
using Store_Application.Application.Services.Users.Queries.GetUserByIdForAdmin;
using Store_Application.Application.Services.Users.Queries.GetUsersForAdmin;
using Store_Application.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin)+","+nameof(Roles.Operator))]
    public class UsersController : Controller
    {
        private readonly IUserFacad _userFacad;

        public UsersController(IUserFacad userFacad)
        {
            _userFacad = userFacad;
        }

        [HttpGet]
        public IActionResult Index(string searchKey = null, int page = 1, int take = 10)
        {
            ViewBag.searchKey = searchKey;
            ViewBag.page = page;
            ViewBag.take = take;
            return View();
        }

        [HttpPost]
        public PartialViewResult LoadUsers(string searchKey = null, int page = 1, int take = 10)
        {
            searchKey = searchKey?.Trim();
            ViewBag.searchKey = searchKey;
            ViewBag.page = page;
            ViewBag.take = take;

            var res = _userFacad.GetUsersForAdminService.Execute(new RequestGetUsersForAdminDto() { Page = page, Searchkey = searchKey, Take = take });

            LoadUsersViewModel model = new LoadUsersViewModel();

            model.Users = res.Data.users.Select(u => new UserViewModel
            {
                Id = u.Id,
                Email = u.Email,
                isActive = u.isActive,
                isRemoved = u.isRemoved,
                RolesName = u.RolesName,
                Username = u.Username
            }).ToList();

            model.Paging = new PagingViewModel
            {
                CurrentPage = res.Data.CurrentPage,
                PageCount = res.Data.PageCount
            };

            return PartialView("/Areas/Admin/Views/Users/_LoadUsers.cshtml", model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Roles = new SelectList(_userFacad.GetRolesForAdminService.Execute().Data, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserViewModel req)
        {
            var RequestValidator = new RegisterUserViewModelValidator(_userFacad);
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            var roles = _userFacad.GetRolesForAdminService.Execute().Data;
            ViewBag.Roles = new SelectList(roles, "Id", "Name",req.Roles);
            if (!Validator.IsValid)
            {
                return View(req);
            }

            var dbRes = _userFacad.RegisterUserForAdminService.Execute(new RequestRegisterUserForAdminDto
            {
                Email = req.Email,
                Password = req.Password,
                Roles = req.Roles.Select(r=> new RegisterRoleDto
                {
                    Id = r,
                }).ToList(),
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
                    ViewBag.RegisterationResult = false;
                    return View(req);
                }
            }

            return Redirect("/Admin/Users/Index");
        }

        [HttpGet]
        public IActionResult Edit(int id, string searchKey, int page, int take)
        {
            if (!_userFacad.isExistUserForAdminService.Execute(id).Data)
            {
                return NotFound();
            }

            ResultGetUserByIdForAdminDto user = _userFacad.GetUserByIdForAdminService.Execute(id).Data;

            EditUserViewModel model = new EditUserViewModel()
            {
                Address = user.Address,
                age = user.age,
                Email = user.Email,
                FullName = user.FullName,
                Id = user.Id,
                Phone = user.Phone,
                Username = user.Username,
                Roles = user.Roles.Select(r=> r.Id).ToList()
            };

            ViewBag.searchKey = searchKey;
            ViewBag.page = page;
            ViewBag.take = take;

            var roles = _userFacad.GetRolesForAdminService.Execute().Data;
            ViewBag.Roles = new SelectList(roles, "Id", "Name");

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditUserViewModel req, string searchKey, int page, int take)
        {
            var RequestValidator = new EditUserViewModelValidator(_userFacad);
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            if (!Validator.IsValid)
            {
                var roles = _userFacad.GetRolesForAdminService.Execute().Data;
                ViewBag.Roles = new SelectList(roles, "Id", "Name", req.Roles);
                return View(req);
            }

            _userFacad.EditUserForAdminService.Execute(new RequestEditUserForAdminDto()
            {
                Address = req.Address,
                age = req.age,
                FullName = req.FullName,
                Id = req.Id,
                Password = req.Password,
                Phone = req.Phone,
                Roles = req.Roles.Select(r=> new EditRoleDto 
                {
                    Id = r
                }).ToList(),
                Username = req.Username,
            });

            return Redirect($"/Admin/Users/Index?searchKey={searchKey}&page={page}&take={take}");
        }

        [HttpPost]
        public IActionResult Delete(int userId)
        {
            return Json(_userFacad.RemoveUserForAdminService.Execute(userId).IsSuccess);
        }

        [HttpPost]
        public IActionResult ChangeStatus(int userId)
        {

            return Json(_userFacad.ChangeUserStatusForAdminService.Execute(userId).Data);
        }
    }
}

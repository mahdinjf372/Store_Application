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
using Store_Application.Application.Services.Users.Commands.EditUser;
using Store_Application.Application.Services.Users.Commands.RegisterUser;
using Store_Application.Application.Services.Users.Queries.GetUserById;
using Store_Application.Application.Services.Users.Queries.GetUsers;
using System.Collections.Generic;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
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

            var res = _userFacad.GetUsersService.Execute(new RequestGetUsersDto() { Page = page, Searchkey = searchKey, Take = take });

            LoadUsersViewModel model = new LoadUsersViewModel();

            model.Users = res.Data.users.Select(u => new UserViewModel
            {
                Id = u.Id,
                Email = u.Email,
                isActive = u.isActive,
                isRemoved = u.isRemoved,
                RoleName = u.RoleName,
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
            ViewBag.Roles = new SelectList(_userFacad.GetRolesService.Execute().Data, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserViewModel req)
        {
            var RequestValidator = new RegisterUserViewModelValidator();
            var Validator = RequestValidator.Validate(req);

            if (!_userFacad.isExistRoleService.Execute(req.RoleId).Data)
            {
                Validator.Errors.Add(new ValidationFailure("RoleId", "لطفا يكي از نقش هاي زير را براي كاربر انتخاب نماييد"));
            }

            Validator.AddToModelState(ModelState, null);
            ViewBag.Roles = new SelectList(_userFacad.GetRolesService.Execute().Data, "Id", "Name");

            if (!Validator.IsValid)
            {
                return View(req);
            }

            var dbRes = _userFacad.RegisterUserService.Execute(new RequestRegisterUserDto
            {
                Email = req.Email,
                Password = req.Password,
                RoleId = req.RoleId,
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
        public IActionResult Edit(int id, string searchKey, int page)
        {
            if (!_userFacad.isExistUserService.Execute(id).Data)
            {
                return NotFound();
            }

            ResultGetUserByIdDto user = _userFacad.GetUserByIdService.Execute(id).Data;

            EditUserViewModel model = new EditUserViewModel()
            {
                Address = user.Address,
                age = user.age,
                Email = user.Email,
                FullName = user.FullName,
                Id = user.Id,
                Phone = user.Phone,
                RoleId = user.RoleId,
                Username = user.Username
            };

            ViewBag.searchKey = searchKey;
            ViewBag.page = page;

            ViewBag.Roles = new SelectList(_userFacad.GetRolesService.Execute().Data, "Id", "Name");
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditUserViewModel req, string searchKey, int page)
        {
            var RequestValidator = new EditUserViewModelValidator();
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            if (!_userFacad.isExistRoleService.Execute(req.RoleId).Data)
            {
                Validator.Errors.Add(new ValidationFailure("RoleId", "لطفا يكي از نقش هاي زير را براي كاربر انتخاب نماييد"));
            }

            if (!Validator.IsValid)
            {
                ViewBag.Roles = new SelectList(_userFacad.GetRolesService.Execute().Data, "Id", "Name");
                return View(req);
            }

            _userFacad.EditUserService.Execute(new RequestEditUserDto()
            {
                Address = req.Address,
                age = req.age,
                FullName = req.FullName,
                Id = req.Id,
                Password = req.Password,
                Phone = req.Phone,
                RoleId = req.RoleId,
                Username = req.Username,
            });

            return Redirect($"/Admin/Users/Index?searchKey={searchKey}&page={page}");
        }

        [HttpPost]
        public IActionResult Delete(int userId)
        {
            return Json(_userFacad.RemoveUserService.Execute(userId).IsSuccess);
        }

        [HttpPost]
        public IActionResult ChangeStatus(int userId)
        {

            return Json(_userFacad.ChangeUserStatusService.Execute(userId).Data);
        }
    }
}

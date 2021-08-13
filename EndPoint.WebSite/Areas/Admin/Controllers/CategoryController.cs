﻿using EndPoint.WebSite.Areas.Admin.Models.Category.AddSubCategory;
using EndPoint.WebSite.Areas.Admin.Models.Category.CreateCategory;
using EndPoint.WebSite.Areas.Admin.Models.Category.EditCategory;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Categories.Commands.AddCategory;
using Store_Application.Application.Services.Categories.Queries.GetCategories;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryFacad _productFacad;
        public CategoryController(ICategoryFacad productFacad)
        {
            _productFacad = productFacad;
        }

        #region Category

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult LoadCategories()
        {
            List<ResultGetCategoriesDto> categories = _productFacad.GetCategoriesService.Execute().Data;
            return PartialView("/Areas/Admin/Views/Category/_LoadCategories.cshtml", categories);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryViewModel req)
        {
            var RequestValidator = new CreateCategoryViewModelValidator();
            var Validator = RequestValidator.Validate(req);

            Validator.AddToModelState(ModelState, null);
            ResultDto res = new ResultDto();

            if (!Validator.IsValid)
            {
                res.Message = Validator.Errors.First().ToString();
                return Json(res);
            }

            if (_productFacad.GetCategoriesService.Execute().Data.Where(c => !c.isRemoved).Count() >= 6)
            {
                res.Message = "به دلیل محدودیت های قالب سایت نمیتوان بیش از ۶ دسته بندی ثبت کرد";
                return Json(res);
            }

            res = _productFacad.AddCategoryService.Execute(new RequestAddCategoryDto
            {
                Title = req.Title,
                ImageName = "noname",
                ParentCategoryId = null
            });

            return Json(res);
        }

        [HttpPost]
        public IActionResult EditCategory(EditCategoryViewModel req)
        {
            var RequestValidator = new EditCategoryViewModelValidator();
            var Validator = RequestValidator.Validate(req);

            ResultDto res = new ResultDto();

            if (!_productFacad.isExistCategoryService.Execute(req.Id).Data)
            {
                res.Message = "شناسه دسته بندی صحیح نیست";
                return Json(res);
            }

            Validator.AddToModelState(ModelState, null);

            if (!Validator.IsValid)
            {
                res.Message = Validator.Errors.First().ToString();
                return Json(res);
            }


            res = _productFacad.EditCategoryService.Execute(req.Id, req.Title);
            res.Message = "عملیات با موفقیت انجام شد";
            return Json(res);
        }

        #endregion

        #region SubCategories

        public PartialViewResult LoadSubCategories(int? parentCategoryId = null)
        {
            var categories = _productFacad.GetCategoriesService.Execute(parentCategoryId);

            return PartialView("Areas/Admin/Views/Category/_LoadSubCategories.cshtml", categories.Data);
        }

        public IActionResult AddSubCategory(AddSubCategoryViewModel req)
        {
            var RequestValidator = new AddSubCategoryViewModelValidator();
            var Validator = RequestValidator.Validate(req);

            Validator.AddToModelState(ModelState, null);
            ResultDto res = new ResultDto();

            if (!Validator.IsValid)
            {
                res.Message = Validator.Errors.First().ToString();
                return Json(res);
            }

            if (!_productFacad.isExistCategoryService.Execute(req.ParentCategoryId).Data)
            {
                res.Message = "لطفا ابتدا گروه را انتخاب کنید";
                return Json(res);
            }

            res = _productFacad.AddCategoryService.Execute(new RequestAddCategoryDto
            {
                Title = req.Title,
                ImageName = null,
                ParentCategoryId = req.ParentCategoryId
            });
            //res.IsSuccess = true;
            //res.Message = "helllllooooooo";
            return Json(res);
        }

        public IActionResult RemoveCategory(int categoryId)
        {
            ResultDto res = new ResultDto();

            if (!_productFacad.isExistCategoryService.Execute(categoryId).Data)
            {
                res.Message = "لطفا دسته بندی خود را به درستی انتخاب نمایید";
                return Json(res);
            }

            res = _productFacad.removeCategoryService.Execute(categoryId);
            res.Message = "دسته بندی مورد نظر با موفقیت حذف شد";

            return Json(true);
        }

        #endregion

    }
}
using EndPoint.WebSite.Areas.Admin.Models.Advertising.Create;
using EndPoint.WebSite.Areas.Admin.Models.Advertising.Edit;
using EndPoint.WebSite.Areas.Admin.Models.Advertising.LoadAdvertisings;
using EndPoint.WebSite.Areas.Admin.Models.Common;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Advertinig.Commands.Add;
using Store_Application.Application.Services.Advertinig.Commands.Edit;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdvertisingController : Controller
    {
        private readonly IAdvertisingFacad _advertisingFacad;
        public AdvertisingController(IAdvertisingFacad advertisingFacad)
        {
            _advertisingFacad = advertisingFacad;
        }

        public IActionResult Index(int page=1, int take=10)
        {
            ViewBag.page = page;
            ViewBag.take = take;
            return View();
        }

        [HttpPost]
        public PartialViewResult LoadAdvertisings(int page, int take)
        {
            ViewBag.page = page;
            ViewBag.take = take;
            var res = _advertisingFacad.GetAdvertisingsForAdminService.Execeute(page,take);

            var ads = res.Data.Ads.Select(a => new AdvertisingViewModel
            {
                Id = a.Id,
                Place = a.Place,
                LinkTo = a.LinkTo,
                ImageName = a.ImageName,
                Description = a.Description,
                Title = a.Title,
                EndDate = a.EndDate,
                StartDate = a.StartDate,
                isRemoved = a.IsRemoved
            }).ToList();

            LoadAdvertisingViewModel model = new LoadAdvertisingViewModel();
            model.ads = ads;

            model.Paging = new PagingViewModel
            {
                CurrentPage = res.Data.CurrentPage,
                PageCount = res.Data.PageCount
            };

            return PartialView("Areas/Admin/Views/Advertising/_LoadAdvertisings.cshtml", model);
        }


        [HttpPost]
        public IActionResult Create(CreateViewModel req)
        {
            var RequestValidator = new CreateViewModelValidator();
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            ResultDto res = new ResultDto();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Message = ModelState.Values.First(v => v.ValidationState == ModelValidationState.Invalid).Errors.First().ErrorMessage;
                if (res.Message.StartsWith("The value "))
                    res.Message = "لطفا مکان بنر را انتخاب نمایید";

                return Json(res);
            }

            res = _advertisingFacad.AddAdvertisingService.Execute(new RequestAddAdvertisingDto
            {
                Title = req.Title,
                Image = req.Image,
                Description = req.Description,
                LinkTo = req.LinkTo,
                Place = req.Place,
                EndDate = req.EndDate,
                StartDate = req.StartDate,
            });

            return Json(res);
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel req)
        {
            var RequestValidator = new EditViewModelValidator();
            var Validator = RequestValidator.Validate(req);
            Validator.AddToModelState(ModelState, null);

            ResultDto res = new ResultDto();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Message = ModelState.Values.First(v => v.ValidationState == ModelValidationState.Invalid).Errors.First().ErrorMessage;
                if (res.Message.StartsWith("The value "))
                    res.Message = "لطفا مکان بنر را انتخاب نمایید";

                return Json(res);
            }

            var isExist = _advertisingFacad.IsExistAdvertisingService.Execute(req.Id).Data;

            if (!isExist)
            {
                res.IsSuccess = false;
                res.Message = "بنری با این شناسه یافت نشد";
                return Json(res);
            }

            res = _advertisingFacad.EditAdvertisingService.Execute(new RequestEditAdvertisingDto
            {
                Id = req.Id,
                Title = req.Title,
                Description = req.Description,
                EndDate = req.EndDate,
                Image = req.Image,
                ImageName = req.ImageName,
                LinkTo = req.LinkTo,
                Place = req.Place,
                StartDate = req.StartDate
            });

            return Json(res);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            ResultDto res = new ResultDto();

            var isExist = _advertisingFacad.IsExistAdvertisingService.Execute(id).Data;

            if (!isExist)
            {
                res.IsSuccess = false;
                res.Message = "بنری با این شناسه یافت نشد";
                return Json(res);
            }

            res = _advertisingFacad.DeleteAdvertisingService.Execute(id);

            return Json(res);
        }
    }
}

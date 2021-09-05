using EndPoint.WebSite.Areas.Admin.Models.MainSlider.Create;
using EndPoint.WebSite.Areas.Admin.Models.MainSlider.Edit;
using EndPoint.WebSite.Areas.Admin.Models.MainSlider.Index;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.MainSlider.Commands.Add;
using Store_Application.Application.Services.MainSlider.Commands.Edit;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MainSliderController : Controller
    {
        private readonly IMainSliderFacad _mainSliderFacad;
        public MainSliderController(IMainSliderFacad mainSliderFacad)
        {
            _mainSliderFacad = mainSliderFacad;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _mainSliderFacad.GetSlidesForAdminService.Execute().Data.Select(s => new MainSlideViewModel
            {
                Id = s.Id,
                ImageName = s.ImageName,
                LinkTo = s.LinkTo,
                Title = s.Title
            });
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateViewModel req)
        {
            var res = new ResultDto();

            if (string.IsNullOrEmpty(req.Title))
            {
                res.IsSuccess = false;
                res.Message = "نام برای اسلاید اجباریست";
                return Json(res);
            }

            if (req.Image == null)
            {
                res.IsSuccess = false;
                res.Message = "تصویر برای اسلاید اجباریست";
                return Json(res);
            }

            res = _mainSliderFacad.AddSlideService.Execute(new RequestAddSlideDto
            {
                Image = req.Image,
                ImageName = req.ImageName,
                LinkTo = req.LinkTo,
                Title = req.Title
            });

            return Json(res);
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel req)
        {
            
            var res = new ResultDto();

            if (string.IsNullOrEmpty(req.Title))
            {
                res.IsSuccess = false;
                res.Message = "نام برای اسلاید اجباریست";
                return Json(res);
            }

            var slide = _mainSliderFacad.GetSlideForAdminService.Execute(req.Id).Data;

            if (slide == null)
            {
                res.IsSuccess = false;
                res.Message = "اسلاید مورد نظر یافت نشد";
                return Json(res);
            }

            res = _mainSliderFacad.EditSlideService.Execute(new RequestEditSlideDto
            {
                Id = req.Id,
                Image = req.Image,
                ImageName = req.ImageName,
                LinkTo = req.LinkTo,
                Title = req.Title
            });

            return Json(res);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var res = new ResultDto();
            var slide = _mainSliderFacad.GetSlideForAdminService.Execute(id).Data;
            if (slide == null)
            {
                res.IsSuccess = false;
                res.Message = "اسلاید مورد نظر یافت نشد";
                return Json(res);
            }

            res = _mainSliderFacad.DeleteSlideService.Execute(id);

            return Json(res);
        }
    }
}

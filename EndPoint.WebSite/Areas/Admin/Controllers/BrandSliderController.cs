using EndPoint.WebSite.Areas.Admin.Models.BrandSlider.Create;
using EndPoint.WebSite.Areas.Admin.Models.BrandSlider.LoadSlides;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.BrandSlider.Commands.Add;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class BrandSliderController : Controller
    {
        private readonly IBrandSliderFacad _brandSliderFacad;
        public BrandSliderController(IBrandSliderFacad brandSliderFacad)
        {
            _brandSliderFacad = brandSliderFacad;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
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

            res = _brandSliderFacad.AddSlideService.Execute(new RequestAddSlideDto
            {
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
            var slide = _brandSliderFacad.GetSlideService.Execute(id).Data;
            if (slide == null)
            {
                res.IsSuccess = false;
                res.Message = "اسلاید مورد نظر یافت نشد";
                return Json(res);
            }

            res = _brandSliderFacad.DeleteSlideService.Execute(id);

            return Json(res);
        }

        [HttpGet]
        public PartialViewResult LoadSlides()
        {
            var model = _brandSliderFacad.GetSlidesService.Execute().Data.Select(s => new LoadSlideViewModel
            {
                Id = s.Id,
                ImageName = s.ImageName,
                LinkTo = s.LinkTo,
                Title = s.Title
            });
            return PartialView("Areas\\Admin\\Views\\BrandSlider\\_LoadSlides.cshtml", model);
        }

    }
}

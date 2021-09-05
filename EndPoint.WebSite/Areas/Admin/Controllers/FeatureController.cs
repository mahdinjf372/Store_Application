using EndPoint.WebSite.Areas.Admin.Models.Feature.LoadFeatures;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureController : Controller
    {
        private readonly IFeatureFacad _featureFacad;
        public FeatureController(IFeatureFacad featureFacad)
        {
            _featureFacad = featureFacad;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoadFeatures(string searchKey, int page)
        {
            var res = _featureFacad.GetFeaturesForAdminService.Execute();

            List<FeatureViewModel> model = res.Data.Select(f => new FeatureViewModel
            {
                Id = f.Id,
                isRemoved = f.isRemoved,
                Title = f.Title
            }).ToList();

            return View("Areas/Admin/Views/Feature/_LoadFeatures.cshtml",model);
        }
        
        [HttpPost]
        public IActionResult CreateFeature(string featureName)
        {
            if (string.IsNullOrEmpty(featureName))
            {
                return Json(new {IsSuccess = false, Message = "لطفا نام ویژگی را وارد کنید" });
            }

            var isExist = _featureFacad.isExistFeatureService.Execute(featureName);
            if (isExist.Data)
            {
                return Json(isExist);
            }

            var res = _featureFacad.AddFeatureService.Execute(featureName);

            return Json(res);
        }

        [HttpPost]
        public IActionResult EditFeatureName(string featureName, int featureId)
        {
            if (featureId == 0 || string.IsNullOrEmpty(featureName))
            {
                return Json(new { IsSuccess = false, Message = "لطفا نام ویژگی را وارد کنید" });
            }

            var res = _featureFacad.EditFeatureService.Execute(featureId,featureName);

            return Json(res);
        }


        [HttpPost]
        public IActionResult DeleteFeature(int featureId)
        {
            var res = _featureFacad.isExistFeatureService.Execute(featureId);
            if (!res.Data)
            {
                res.IsSuccess = false;
                res.Message = "شناسه ویژگی یافت نشد";
                return Json(res);
            }

            var res2 = _featureFacad.DeleteFeatureService.Execute(featureId);

            return Json(res2);
        }

    }
}

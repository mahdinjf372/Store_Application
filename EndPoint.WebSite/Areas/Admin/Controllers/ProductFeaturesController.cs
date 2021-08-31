using EndPoint.WebSite.Areas.Admin.Models.ProductFeatures.LoadFeatures;
using EndPoint.WebSite.Areas.Admin.Models.ProductFeatures.LoadProductFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.ProductFeatures.Commands.AddProductFeature;
using Store_Application.Application.Services.ProductFeatures.Commands.EditProductFeature;
using Store_Application.Application.Services.ProductFeatures.Queries.IsExistProductFeature;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductFeaturesController : Controller
    {
        private readonly IProductFeaturesFacad _pfFacad;
        private readonly IFeatureFacad _featureFacad;
        public ProductFeaturesController(IProductFeaturesFacad pfFacade, IFeatureFacad featureFacad)
        {
            _pfFacad = pfFacade;
            _featureFacad = featureFacad;
        }

        [HttpGet]
        public IActionResult Index(int productId)
        {
            ViewBag.ProductId = productId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(int productId, int featureId, string value)
        {

            if (string.IsNullOrEmpty(value))
            {
                return Json(new ResultDto
                {
                    IsSuccess = false,
                    Message = "مقدار ویژگی را وارد کنید"
                });
            }

            var IsExist = _pfFacad.isExistProductFeatureService.Execute(new RequestIsExistProductFeatureDto
            {
                FeatureId = featureId,
                ProductId = productId,
                Value = value
            });
            ResultDto res;
            if (!IsExist.Data)
            {
                res = _pfFacad.AddProductFeatureService.Execute(new RequestAddProductFeatureDto
                {
                    Value = value,
                    FeatureId = featureId,
                    ProductId = productId,
                    IsBold = false
                });

                return Json(res);
            }

            return Json(new ResultDto
            {
                IsSuccess = false,
                Message = "ویژگی تکراری میباشد"
            });
        }

        [HttpPost]
        public IActionResult Edit(int pfId, string value)
        {

            if (string.IsNullOrEmpty(value))
            {
                return Json(new ResultDto
                {
                    IsSuccess = false,
                    Message = "مقدار ویژگی را وارد کنید"
                });
            }

            var res = _pfFacad.EditProductFeatureService.Execute(new RequestEditProductFeatureDto
            {
                PF_Id = pfId,
                Value = value,
            });

            return Json(res);
        }

        [HttpPost]
        public IActionResult Delete(int productFeatureId)
        {
            var isExist = _pfFacad.isExistProductFeatureService.Execute(productFeatureId);

            if (isExist.Data)
            {
                var res = _pfFacad.DeleteProductFeatureService.Execute(productFeatureId);

                return Json(res);
            }

            return Json(false);
        }

        [HttpPost]
        public IActionResult ChangeBoldStatus(int productFeatureId)
        {
            var isExist = _pfFacad.isExistProductFeatureService.Execute(productFeatureId);

            if (isExist.Data)
            {
                var res = _pfFacad.ChangeBoldStatusService.Execute(productFeatureId);

                return Json(res);
            }

            return Json(false);
        }

        [HttpPost]
        public PartialViewResult LoadProductFeatures(int productId)
        {
            var res = _pfFacad.GetProductFeaturesService.Execute(productId);

            List<LoadProductFeaturesViewModel> model = new List<LoadProductFeaturesViewModel>();
            if (res.IsSuccess)
                model = res.Data.Select(pf => new LoadProductFeaturesViewModel
                {
                    Id = pf.Id,
                    FeatureName = pf.FeatureName,
                    IsBold = pf.IsBold,
                    Value = pf.Value,
                    IsRemoved = pf.IsRemoved
                }).ToList();

            return PartialView("/Areas/Admin/Views/ProductFeatures/_LoadProductFeatures.cshtml", model);
        }

        [HttpGet]
        public PartialViewResult LoadFeatures()
        {
            var res = _featureFacad.GetFeaturesService.Execute();

            List<LoadFeaturesViewModel> model = res.Data.Where(f => !f.isRemoved).Select(f => new LoadFeaturesViewModel
            {
                Id = f.Id,
                Title = f.Title
            }).ToList();

            return PartialView("/Areas/Admin/Views/ProductFeatures/_LoadFeatures.cshtml", model);
        }
    }
}

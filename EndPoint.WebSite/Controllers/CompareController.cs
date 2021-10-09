using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Models.Compare.Index;
using EndPoint.WebSite.Utilities;
using Store_Application.Application.Interfaces.FacadPattern;

namespace EndPoint.WebSite.Controllers
{
    public class CompareController : Controller
    {
        private readonly ClaimUtility _claimUtility;
        private readonly CookiesManager _cookiesManager;
        private readonly ICompareFacad _compareFacad;

        public CompareController(ClaimUtility claimUtility, CookiesManager cookiesManager, ICompareFacad compareFacad)
        {
            _claimUtility = claimUtility;
            _cookiesManager = cookiesManager;
            _compareFacad = compareFacad;   
        }

        public IActionResult Index()
        {
            int? userId = null;
            if (_claimUtility.IsAuthenticated(User))
            {
                userId = _claimUtility.GetUserId(User);
            }

            var browserId = _cookiesManager.GetBrowserId(HttpContext);

            var res = _compareFacad.GetCompareListService.Execute(browserId, userId);

            var model = new List<CompareViewModel>();

            if (res.IsSuccess)
            {
                foreach (var compare in res.Data)
                {
                    var compareItem = new CompareViewModel();

                    compareItem.Product = new ProductCompareViewModel()
                    {
                        Id = compare.Product.Id,
                        Price = compare.Product.Price,
                        DiscountAmount = compare.Product.DiscountAmount,
                        PriceWithDiscount = compare.Product.PriceWithDiscount,
                        ImageName = compare.Product.ImageName,
                        Title = compare.Product.Title,
                        Inventory = compare.Product.Inventory
                    };

                    compareItem.Feature = compare.Feature.Select(f => new FeatureViewModel()
                    {
                        Id = f.Id,
                        Title = f.Title
                    }).ToList();

                    compareItem.ProductFeature = compare.ProductFeature.Select(pf => new ProductFeatureViewModel()
                    {
                        Id = pf.Id,
                        FeatureId = pf.FeatureId,
                        IsBold = pf.IsBold,
                        ProductId = pf.ProductId,
                        Value = pf.Value
                    }).ToList();

                    model.Add(compareItem);
                }
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult AddToCompare(int productId)
        {
            int? userId = null;
            if (_claimUtility.IsAuthenticated(User))
            {
                userId = _claimUtility.GetUserId(User);
            }

            var browserId = _cookiesManager.GetBrowserId(HttpContext);

            var res = _compareFacad.AddToCompareService.Execute(productId, browserId, userId);

            return Json(res);
        }

        [HttpPost]
        public IActionResult RemoveFromCompare(int productId)
        {
            int? userId = null;
            if (_claimUtility.IsAuthenticated(User))
            {
                userId = _claimUtility.GetUserId(User);
            }

            var browserId = _cookiesManager.GetBrowserId(HttpContext);

            var res = _compareFacad.RemoveFromFavoriteService.Execute(productId, browserId, userId);

            return Json(res);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Models.Compare.Index;
using EndPoint.WebSite.Utilities;
using Store_Application.Application.Interfaces.FacadPattern;
using AutoMapper;

namespace EndPoint.WebSite.Controllers
{
    public class CompareController : Controller
    {
        private readonly ClaimUtility _claimUtility;
        private readonly CookiesManager _cookiesManager;
        private readonly ICompareFacad _compareFacad;
        private readonly IMapper _mapper;

        public CompareController(ClaimUtility claimUtility,
            CookiesManager cookiesManager,
            ICompareFacad compareFacad,
            IMapper mapper)
        {
            _claimUtility = claimUtility;
            _cookiesManager = cookiesManager;
            _compareFacad = compareFacad;
            _mapper = mapper;
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

                    compareItem.Product = _mapper.Map<ProductCompareViewModel>(compare.Product);

                    compareItem.Feature = _mapper.Map<List<FeatureViewModel>>(compare.Feature);

                    compareItem.ProductFeature = _mapper.Map<List<ProductFeatureViewModel>>(compare.ProductFeature);

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

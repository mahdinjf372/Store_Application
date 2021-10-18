using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Favorite.Commands.AddToFavorite;
using Store_Application.Application.Services.Favorite.Commands.RemoveFromFavorite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Areas.UserPanel.Models.Favorite.Index;
using AutoMapper;

namespace EndPoint.WebSite.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class FavoriteController : Controller
    {
        private readonly IFavoriteFacad _favoriteFacad;
        private readonly ClaimUtility _claimUtility;
        private readonly CookiesManager _cookiesManager;
        private readonly IMapper _mapper;

        public FavoriteController(
            IFavoriteFacad favoriteFacad,
            ClaimUtility claimUtility,
            CookiesManager cookiesManager,
            IMapper mapper)
        {
            _favoriteFacad = favoriteFacad;
            _claimUtility = claimUtility;
            _cookiesManager = cookiesManager;
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

            var res = _favoriteFacad.GetFavoriteListService.Execute(browserId, userId);

            List<FavoriteListViewModel> model = new List<FavoriteListViewModel>();

            if (res.IsSuccess)
            {
                model = _mapper.Map<List<FavoriteListViewModel>>(res.Data);
            }

            ViewBag.FavorityListIsActived = "active";

            return View(model);
        }

        [HttpPost]
        public IActionResult AddToFavorite(int productId)
        {
            int? userId = null;
            if (_claimUtility.IsAuthenticated(User))
            {
                userId = _claimUtility.GetUserId(User);
            }

            var browserId = _cookiesManager.GetBrowserId(HttpContext);

            var res = _favoriteFacad.AddToFavoriteService.Execute(new RequestAddProductToFavoriteDto
            {
                UserId = userId,
                BrowserId = browserId,
                ProductId = productId
            });

            return Json(res);
        }

        [HttpPost]
        public IActionResult RemoveFromFavorite(int productId)
        {
            int? userId = null;
            if (_claimUtility.IsAuthenticated(User))
            {
                userId = _claimUtility.GetUserId(User);
            }

            var browserId = _cookiesManager.GetBrowserId(HttpContext);

            var res = _favoriteFacad.RemoveFromFavoriteService.Execute(new RequestRemoveProductFromFavoriteDto
            {
                UserId = userId,
                BrowserId = browserId,
                ProductId = productId
            });
            
            return Json(res);
        }
    }
}

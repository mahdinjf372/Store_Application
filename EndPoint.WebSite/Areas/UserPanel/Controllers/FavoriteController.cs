using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Favorite.Commands.AddToFavorite;
using Store_Application.Application.Services.Favorite.Commands.RemoveFromFavorite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class FavoriteController : Controller
    {
        private readonly IFavoriteFacad _favoriteFacad;
        private readonly ClaimUtility _claimUtility;
        private readonly CookiesManager _cookiesManager;

        public FavoriteController(
            IFavoriteFacad favoriteFacad,
            ClaimUtility claimUtility,
            CookiesManager cookiesManager)
        {
            _favoriteFacad = favoriteFacad;
            _claimUtility = claimUtility;
            _cookiesManager = cookiesManager;
        }



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

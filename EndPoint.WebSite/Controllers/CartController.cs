using AutoMapper;
using EndPoint.WebSite.Models.Cart.Index;
using EndPoint.WebSite.Models.Cart.LoadCart;
using EndPoint.WebSite.Models.Cart.SaveCartChanges;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Carts.Commands.AddCart;
using Store_Application.Application.Services.Carts.Commands.AddProductToCart;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace EndPoint.WebSite.Controllers
{

    public class CartController : Controller
    {
        private readonly ICartFacad _cartFacad;
        private readonly CookiesManager _cookiesManager;
        private readonly ClaimUtility _claimUtility;
        private readonly IMapper _mapper;

        public CartController(ICartFacad cartFacad,
            CookiesManager cookiesManager,
            ClaimUtility claimUtility,
            IMapper mapper)
        {
            _cartFacad = cartFacad;
            _cookiesManager = cookiesManager;
            _claimUtility = claimUtility;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var userId = _claimUtility.GetUserId(User);
            var browserId = _cookiesManager.GetBrowserId(HttpContext);

            if (_claimUtility.IsAuthenticated(User))
            {
                _cartFacad.MergeUserCartAndBrowserCartService.Execute(userId, browserId);
            }

            var res = _cartFacad.GetCartForSiteService.Execute(userId, browserId);

            var model = _mapper.Map<Models.Cart.Index.CartViewModel>(res.Data);

            return View(model);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int count)
        {
            var browserId = _cookiesManager.GetBrowserId(HttpContext);
            var userId = _claimUtility.GetUserId(User);

            if (_claimUtility.IsAuthenticated(User))
            {
                if (_cartFacad.IsExistCartByUserIdService.Execute(userId).Data)
                {
                    _cartFacad.MergeUserCartAndBrowserCartService.Execute(userId, browserId);
                }
                else
                {
                    _cartFacad.AddCartService.Execute(new RequestAddCartDto
                    {
                        BrowserId = Guid.Empty,
                        UserId = userId,
                    });
                    _cartFacad.MergeUserCartAndBrowserCartService.Execute(userId, browserId);
                }
            }
            else
            {
                if (!_cartFacad.IsExistCartByBrowserIdService.Execute(browserId).Data)
                {
                    _cartFacad.AddCartService.Execute(new RequestAddCartDto
                    {
                        BrowserId = browserId,
                        UserId = null,
                    });
                }
            }

            var res = _cartFacad.AddProductToCartService.Execute(new RequestAddProductToCartDto
            {
                BrowserId = browserId,
                ProductId = productId,
                UserId = userId,
                Count = count
            });

            return Json(res);
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int ProductId)
        {
            var browserId = _cookiesManager.GetBrowserId(HttpContext);
            var userId = _claimUtility.GetUserId(User);

            if (_claimUtility.IsAuthenticated(User))
            {
                if (!_cartFacad.IsExistCartByUserIdService.Execute(userId).Data)
                {
                    _cartFacad.AddCartService.Execute(new RequestAddCartDto
                    {
                        BrowserId = Guid.Empty,
                        UserId = userId
                    });
                }
            }
            else
            {
                if (!_cartFacad.IsExistCartByBrowserIdService.Execute(browserId).Data)
                {
                    _cartFacad.AddCartService.Execute(new RequestAddCartDto
                    {
                        BrowserId = browserId,
                        UserId = 0
                    });
                }
            }

            var res = _cartFacad.DeleteProductService.Execute(ProductId, userId, browserId);
            return Json(res);
        }

        [HttpGet]
        public PartialViewResult LoadCart()
        {
            var browserId = _cookiesManager.GetBrowserId(HttpContext);
            var userId = _claimUtility.GetUserId(User);

            if (_claimUtility.IsAuthenticated(User))
            {
                if (!_cartFacad.IsExistCartByUserIdService.Execute(userId).Data)
                {
                    _cartFacad.AddCartService.Execute(new RequestAddCartDto
                    {
                        BrowserId = Guid.Empty,
                        UserId = userId,
                    });
                }
                _cartFacad.MergeUserCartAndBrowserCartService.Execute(userId, browserId);
            }
            else
            {
                if (!_cartFacad.IsExistCartByBrowserIdService.Execute(browserId).Data)
                {
                    _cartFacad.AddCartService.Execute(new RequestAddCartDto
                    {
                        BrowserId = browserId,
                        UserId = null,
                    });
                }
            }

            var res = _cartFacad.GetCartForSiteService.Execute(userId, browserId);

            var model = _mapper.Map<Models.Cart.LoadCart.CartViewModel>(res.Data);

            return PartialView("_BasketCart", model);
        }

        public IActionResult SaveCartChanges(SaveCartViewModel req)
        {
            var userId = _claimUtility.GetUserId(User);
            var browserId = _cookiesManager.GetBrowserId(HttpContext);
            var res = new ResultDto();
            var isAuthenticated = _claimUtility.IsAuthenticated(User);

            foreach (var item in req.CartItems)
            {
                if (isAuthenticated)
                {
                    res = _cartFacad.AddProductToCartService.Execute(new RequestAddProductToCartDto
                    {
                        BrowserId = Guid.Empty,
                        ProductId = item.ProductId,
                        UserId = userId,
                        FinallyCount = item.Count
                    });
                    if (res.IsSuccess)
                        res.Message = "/Checkout";
                }
                else
                {
                    res = _cartFacad.AddProductToCartService.Execute(new RequestAddProductToCartDto
                    {
                        BrowserId = browserId,
                        ProductId = item.ProductId,
                        UserId = 0,
                        FinallyCount = item.Count
                    });
                    res.Message = "/Login?ReturnUrl=Cart";
                }

                if (!res.IsSuccess)
                {
                    //res.Message = "ثبت تغییرات با شکست مواجه شد صفحه را رفرش کرده و دوباره امتحان کنید";
                    break;
                }
            }

            _cartFacad.MergeUserCartAndBrowserCartService.Execute(userId, browserId);
            return Json(res);
        }

    }
}

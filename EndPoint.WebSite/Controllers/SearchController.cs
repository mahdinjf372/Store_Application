using EndPoint.WebSite.Areas.Admin.Models.Common;
using EndPoint.WebSite.Models.Search.Index;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Products.Queries.GetProductsForSite;
using System.Collections.Generic;
using System.Linq;

namespace Store.EndPoint.UI.Site.Controllers
{
    public class SearchController : Controller
    {
        private readonly IProductFacad _productFacad;
        public SearchController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }

        [Route("Search")]
        public IActionResult Index( string sortBy, string searchTitle = null, int pageId = 1, int take = 10, int? categoryId = null)
        {
            ViewBag.SearchType = "Search";
            ViewBag.SearchTitle = searchTitle;
            ViewBag.SortBy = sortBy ?? "جدیدترین";
            ViewBag.ArchiveTitle = "جستوجو برای " + searchTitle;
            ViewBag.Take = take;
            ViewBag.PageId = take;
            var res = _productFacad.GetProductsForSiteService.Execute(new RequestGetProductsForSiteDto
            {
                Page = pageId,
                Searchkey = searchTitle,
                SortBy = sortBy,
                Take = take,
                CategoryId = categoryId
            });

            SearchViewModel model = new SearchViewModel();
            if (res.IsSuccess)
            {
                List<SearchProductViewModel> products = res.Data.Products.Select(p => new SearchProductViewModel
                {
                    Id = p.Id,
                    ImageTitle = p.ImageTitle,
                    Price = p.Price,
                    Title = p.Title,
                    SubgroupTitle = p.SubgroupTitle,
                    GroupTitle = p.GroupTitle,
                    CategoryTitle = p.CategoryTitle,
                    PriceWihtDiscount = p.PriceWihtDiscount,
                    DiscountAmount = p.DiscountAmount
                }).ToList();

                model = new SearchViewModel()
                {
                    Products = products,
                    Paging = new PagingViewModel
                    {
                        CurrentPage = res.Data.CurrentPage,
                        PageCount = res.Data.PageCount
                    }
                };
            }

            return View(model);
        }
    }
}

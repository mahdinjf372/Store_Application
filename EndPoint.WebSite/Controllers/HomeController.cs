using EndPoint.WebSite.Models;
using EndPoint.WebSite.Models.Home.Index;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store_Application.Application.Interfaces.FacadPattern;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryFacad _categoryFacad;
        public HomeController(ICategoryFacad categoryFacad)
        {
            _categoryFacad = categoryFacad;
        }

        public IActionResult Index()
        {
            //HomeViewModel model = new HomeViewModel();

            //var categories = _categoryFacad.GetCategoriesService.Execute();

            //model.Categories = categories.Data.Select(c => new CategoryViewModel
            //{
            //    Id = c.Id,
            //    Title = c.Title,
            //    ParentId = c.ParentCategoryId
            //});

            return View();
        }

    }
}

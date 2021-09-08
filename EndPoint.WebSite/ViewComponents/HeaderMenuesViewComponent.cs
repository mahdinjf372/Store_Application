using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Models.Components.HeaderMenues;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;

namespace EndPoint.WebSite.ViewComponents
{
    public class HeaderMenuesViewComponent : ViewComponent
    {
        private readonly ICategoryFacad _categoryFacad;
        public HeaderMenuesViewComponent(ICategoryFacad categoryFacad)
        {
            _categoryFacad = categoryFacad;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cats = _categoryFacad.GetCategoriesService.Execute();

            List<CategoryViewModel> model = cats.Data.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                ImageName = c.ImageName,
                ParentCategoryId = c.ParentCategoryId,
                Title = c.Title
            }).ToList();

            return View("/Views/Shared/Components/HeaderMenues/HeaderMenues.cshtml", model);
        }
    }
}

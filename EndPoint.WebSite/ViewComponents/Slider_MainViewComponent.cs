using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Store_Application.Application.Interfaces.FacadPattern;
using EndPoint.WebSite.Models.Components.Slider_Main;
using System.Collections.Generic;
using System.Linq;

namespace Store.EndPoint.UI.Site.Components
{
    public class Slider_MainViewComponent : ViewComponent
    {
        private IMainSliderFacad _mainSliderFacad;
        public Slider_MainViewComponent(IMainSliderFacad mainSliderFacad)
        {
            _mainSliderFacad = mainSliderFacad;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slides = _mainSliderFacad.GetSlidesService.Execute();

            List<MainSlideViewModel> model = slides.Data.Select(s => new MainSlideViewModel
            {
                Id = s.Id,
                Title = s.Title,
                LinkTo = s.LinkTo,
                ImageName = s.ImageName
            }).ToList();

            return View("/Views/Shared/Components/Slider_Main/Slider_Main.cshtml", model);
        }
    }
}

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Store_Application.Application.Interfaces.FacadPattern;
using EndPoint.WebSite.Models.Components.Banners_Top;
using System.Collections.Generic;

namespace Store.EndPoint.UI.Site.Components
{
    public class Banners_TopViewComponent : ViewComponent
    {
        private IAdvertisingFacad _advertisingFacad;
        public Banners_TopViewComponent(IAdvertisingFacad advertisingFacad)
        {
            _advertisingFacad = advertisingFacad;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ads = _advertisingFacad.GetAdvertisingsService.Execeute();

            List<BannerViewModel> model = ads.Data.Select(b => new BannerViewModel
            {
                Id = b.Id,
                Title = b.Title,
                ImageName = b.ImageName,
                LinkTo = b.LinkTo,
                Place = b.Place
            }).ToList();
            
            return View("/Views/Shared/Components/Banners_Top/Banners_Top.cshtml", model);
        }
    }
}

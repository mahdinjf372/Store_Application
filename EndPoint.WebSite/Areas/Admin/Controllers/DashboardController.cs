using EndPoint.WebSite.Areas.Admin.Models.Dashboard.LoadSiteRequestCount;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.SiteRequest.Queries.GetSiteRequestsPerTime;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + "," + nameof(Roles.Operator))]
    public class DashboardController : Controller
    {
        private readonly ISiteRequestFacad _siteRequestFacad;
        private readonly ISearchKeyInfoFacad _searchKeyInfoFacad;
        private readonly IRequestPayFacad _requestPayFacad;
        public DashboardController(ISiteRequestFacad siteRequestFacad,
            ISearchKeyInfoFacad searchKeyInfoFacad,
            IRequestPayFacad requestPayFacad)
        {
            _siteRequestFacad = siteRequestFacad;
            _searchKeyInfoFacad = searchKeyInfoFacad;
            _requestPayFacad = requestPayFacad;
        }

        public IActionResult Index()
        {
            ViewBag.totalOrders = _requestPayFacad.GetTotalPaysForAdminService.Execute().Data;
            ViewBag.totalSearchKey = _searchKeyInfoFacad.GetTotalCountOfSearchService.Execute().Data;
            return View();
        }

        [HttpPost]
        public IActionResult LoadSiteRequestCount(PerTime timing)
        {
            var res = _siteRequestFacad.GetSiteRequestsPerTimeService.Execute(new RequestGetSiteRequestDto
            {
                PerTime = timing
            });

            var model = new SiteRequestCountChartViewModel();

            model.Count = res.Data.Select(r=> r.Count).ToArray();
            model.TimeLabel = res.Data.Select(r => r.TimeRange.FromTimeForView + "-" + r.TimeRange.ToTimeForView).ToArray();

            return Json(model);
        }
    }
}

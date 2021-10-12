using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Dashboard.LoadSiteRequestCount
{
    public class SiteRequestCountChartViewModel
    {
        public long[] Count { get; set; }
        public string[] TimeLabel { get; set; }
    }
}

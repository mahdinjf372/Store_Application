using EndPoint.WebSite.Areas.Admin.Models.Common;
using System.Collections.Generic;

namespace EndPoint.WebSite.Areas.Admin.Models.Advertising.LoadAdvertisings
{
    public class LoadAdvertisingViewModel
    {
        public List<AdvertisingViewModel> ads { get; set; }
        public PagingViewModel Paging { get; set; }
    }
}

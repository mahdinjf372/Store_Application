using EndPoint.WebSite.Areas.Admin.Models.Common;
using System.Collections.Generic;

namespace EndPoint.WebSite.Models.Search.Index
{
    public class SearchViewModel
    {
        public IEnumerable<SearchProductViewModel> Products { get; set; }

        public PagingViewModel Paging { get; set; }

    }
}

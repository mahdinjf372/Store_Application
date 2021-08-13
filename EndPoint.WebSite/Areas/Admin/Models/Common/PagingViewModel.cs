using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Common
{
    public class PagingViewModel
    {
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
}

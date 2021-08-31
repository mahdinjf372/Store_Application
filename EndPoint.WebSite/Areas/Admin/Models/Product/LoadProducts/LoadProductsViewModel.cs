using EndPoint.WebSite.Areas.Admin.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Product.LoadProducts
{
    public class LoadProductsViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        public PagingViewModel Paging { get; set; }
    }
}

using EndPoint.WebSite.Areas.Admin.Models.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Order.LoadOrders
{
    public class LoadOrdersViewModel
    {
        public List<OrderViewModel> Orders { get; set; }

        public PagingViewModel Paging { get; set; }

    }
}

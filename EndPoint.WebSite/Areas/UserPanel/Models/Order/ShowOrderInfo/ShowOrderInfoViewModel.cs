using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.UserPanel.Models.Order.ShowOrderInfo
{
    public class ShowOrderInfoViewModel
    {
        public int Id { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public decimal totalAmount { get; set; }

        public List<OrderDetailViewModel> OrderDetails { get; set; }
    }
}

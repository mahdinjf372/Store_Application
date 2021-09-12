using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Checkout.FinalOrderInfo
{
    public class FinalOrderInfoViewModel
    {
        public int RequestPayId { get; set; }
        public string RefId { get; set; }
        public DateTime FinallyDate { get; set; }
        public decimal PayedAmount { get; set; }
        public List<OrderDetailViewModel> orderDetails { get; set; }
    }

    public class OrderDetailViewModel
    {
        public decimal Price { get; set; }
        public decimal SumPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Checkout.Index
{
    public class CheckoutViewModel
    {
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public decimal TotalAmount { get; set; }
        public bool agreeToTermsAndConditions { get; set; }

        public List<OrderDetailViewModel> OrderDetails { get; set; }
    }

}

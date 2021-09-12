using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Cart.Index
{
    public class CartViewModel
    {
        public int CartId { get; set; }
        public int ProductCount { get; set; }
        public decimal SumAmount { get; set; }
        public List<CartItemViewModel> CartItems { get; set; }
    }
}

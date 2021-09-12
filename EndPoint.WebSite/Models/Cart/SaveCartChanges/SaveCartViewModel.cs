using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Cart.SaveCartChanges
{
    public class SaveCartViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }
    }

    public class CartItemViewModel
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
    }
}

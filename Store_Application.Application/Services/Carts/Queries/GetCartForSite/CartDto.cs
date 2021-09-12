using System.Collections.Generic;

namespace Store_Application.Application.Services.Carts.Queries.GetCartForSite
{
    public class CartDto
    {
        public int CartId { get; set; }
        public int ProductCount { get; set; }
        public decimal SumAmount { get; set; }
        public List<CartItemDto> CartItems { get; set; }
    }

}

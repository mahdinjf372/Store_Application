using System;

namespace Store_Application.Application.Services.Carts.Commands.AddProductToCart
{
    public class RequestAddProductToCartDto
    {
        public int ProductId { get; set; }
        public int? UserId { get; set; }
        public Guid BrowserId { get; set; }
        public int Count { get; set; }
        public int FinallyCount { get; set; }

    }
}

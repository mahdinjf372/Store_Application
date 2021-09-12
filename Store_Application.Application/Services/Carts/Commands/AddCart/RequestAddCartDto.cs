using System;

namespace Store_Application.Application.Services.Carts.Commands.AddCart
{
    public class RequestAddCartDto
    {
        public int ProductId { get; set; }
        public int? UserId { get; set; }
        public Guid BrowserId { get; set; }

    }
}

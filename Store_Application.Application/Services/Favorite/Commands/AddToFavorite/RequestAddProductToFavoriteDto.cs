using System;

namespace Store_Application.Application.Services.Favorite.Commands.AddToFavorite
{
    public class RequestAddProductToFavoriteDto
    {
        public int ProductId { get; set; }
        public int? UserId { get; set; }
        public Guid BrowserId { get; set; }
    }
}

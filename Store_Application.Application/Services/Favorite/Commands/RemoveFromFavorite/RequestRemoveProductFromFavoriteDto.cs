using System;

namespace Store_Application.Application.Services.Favorite.Commands.RemoveFromFavorite
{
    public class RequestRemoveProductFromFavoriteDto
    {
        public int ProductId { get; set; }
        public int? UserId { get; set; }
        public Guid BrowserId { get; set; }
    }
}

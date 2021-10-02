using Store_Application.Application.Services.Favorite.Commands.AddToFavorite;
using Store_Application.Application.Services.Favorite.Commands.MergeFavoriteLists;
using Store_Application.Application.Services.Favorite.Commands.RemoveFromFavorite;
using Store_Application.Application.Services.Favorite.Queries.IsFavoriteProduct;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IFavoriteFacad
    {
        IAddToFavoriteService AddToFavoriteService { get; }
        IRemoveFromFavoriteService RemoveFromFavoriteService { get; }
        IMergeFavoriteListService MergeFavoriteListService { get; }
        IisFavoriteProductService IsFavoriteProductService { get; }
    }
}

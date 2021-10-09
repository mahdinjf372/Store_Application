using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Favorite.Commands.AddToFavorite;
using Store_Application.Application.Services.Favorite.Commands.MergeFavoriteLists;
using Store_Application.Application.Services.Favorite.Commands.RemoveFromFavorite;
using Store_Application.Application.Services.Favorite.Queries.IsFavoriteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Application.Services.Favorite.Queries.GetFavoriteList;

namespace Store_Application.Application.Services.Favorite.FacadPattern
{
    public class FavoriteFacad : IFavoriteFacad
    {
        private readonly IDataBaseContext _db;
        public FavoriteFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IAddToFavoriteService _addToFavoriteService;
        public IAddToFavoriteService AddToFavoriteService
        {
            get
            {
                return _addToFavoriteService ??= new AddToFavoriteService(_db);
            }
        }

        private IRemoveFromFavoriteService _removeFromFavoriteService;
        public IRemoveFromFavoriteService RemoveFromFavoriteService
        {
            get
            {
                return _removeFromFavoriteService ??= new RemoveFromFavoriteService(_db);
            }
        }

        private IMergeFavoriteListService _mergeFavoriteListService;
        public IMergeFavoriteListService MergeFavoriteListService
        {
            get
            {
                return _mergeFavoriteListService ??= new MergeFavoriteListService(_db);
            }
        }

        private IisFavoriteProductService _isFavoriteProductService;
        public IisFavoriteProductService IsFavoriteProductService
        {
            get
            {
                return _isFavoriteProductService ??= new IsFavoriteProductService(_db);
            }
        }
        
        private IGetFavoriteListService _getFavoriteListService;
        public IGetFavoriteListService GetFavoriteListService
        {
            get
            {
                return _getFavoriteListService ??= new GetFavoriteListService(_db);
            }
        }
    }
}

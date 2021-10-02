using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Favorite.Commands.RemoveFromFavorite
{
    public class RemoveFromFavoriteService : IRemoveFromFavoriteService
    {
        private readonly IDataBaseContext _db;
        public RemoveFromFavoriteService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestRemoveProductFromFavoriteDto req)
        {
            var favorite = new Domain.Entities.Favorite.Favorite();
            if (req.UserId == null)
            {
                favorite = _db.Favorites.SingleOrDefault(f => f.ProductId.Equals(req.ProductId) && f.BrowserId.Equals(req.BrowserId));
            }
            else
            {
                favorite = _db.Favorites.SingleOrDefault(f => f.ProductId.Equals(req.ProductId) && f.UserId.Equals(req.UserId));
            }

            ResultDto res = new ResultDto();
            res.IsSuccess = false;

            if (favorite != null)
            {
                favorite.isRemoved = true;
                favorite.RemovedTime = DateTime.Now;

                _db.Favorites.Update(favorite);
                _db.SaveChanges();

                res.IsSuccess = true;
            }

            return res;
        }
    }
}

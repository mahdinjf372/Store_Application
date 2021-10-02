using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Favorite.Commands.AddToFavorite
{
    public class AddToFavoriteService : IAddToFavoriteService
    {
        private readonly IDataBaseContext _db;
        public AddToFavoriteService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddProductToFavoriteDto req)
        {
            bool isExist = false;
            if (req.UserId == null)
            {
                 isExist = _db.Favorites.Any(f => f.ProductId.Equals(req.ProductId) && f.BrowserId.Equals(req.BrowserId));
            }
            else
            {
                 isExist = _db.Favorites.Any(f => f.ProductId.Equals(req.ProductId) && f.UserId.Equals(req.UserId));
            }

            ResultDto res = new ResultDto();
            res.IsSuccess = false;

            if (!isExist)
            {
                var favorite = new Domain.Entities.Favorite.Favorite()
                {
                    InsertTime = DateTime.Now,
                    ProductId = req.ProductId,
                    UserId = req.UserId,
                    BrowserId = req.BrowserId
                };

                _db.Favorites.Add(favorite);
                _db.SaveChanges();

                res.IsSuccess = true;
            }

            return res;
        }
    }
}

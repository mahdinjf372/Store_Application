using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Favorite.Commands.MergeFavoriteLists
{
    public class MergeFavoriteListService : IMergeFavoriteListService
    {
        private readonly IDataBaseContext _db;
        public MergeFavoriteListService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int userId, Guid browserId)
        {
            var userFavorites = _db.Favorites.Where(f => f.UserId == userId).ToList();
            var browserFavorites = _db.Favorites.Where(f => f.UserId == null && f.BrowserId == browserId).ToList();

            if (browserFavorites.Any())
            {
                foreach (var bf in browserFavorites)
                {
                    var favorite = userFavorites.SingleOrDefault(f => f.ProductId.Equals(bf.ProductId));

                    if (favorite == null)
                    {
                        bf.UserId = userId;
                    }
                    else
                    {
                        bf.isRemoved = true;
                        bf.RemovedTime = DateTime.Now;
                    }
                    _db.Favorites.Update(bf);
                    _db.SaveChanges();
                }
            }

            return new ResultDto
            {
                IsSuccess = true,
            };
        }
    }
}

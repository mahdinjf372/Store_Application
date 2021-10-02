using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Favorite.Queries.IsFavoriteProduct
{
    public class IsFavoriteProductService : IisFavoriteProductService
    {
        private readonly IDataBaseContext _db;
        public IsFavoriteProductService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int productId, Guid browserId, int? userId = null)
        {
            bool isExist = false;
            if (userId!=null)
            {
                isExist = _db.Favorites.Any(f => f.ProductId == productId && f.UserId == userId );
            }
            else
            {
                isExist = _db.Favorites.Any(f => f.ProductId==productId && f.BrowserId == browserId && f.UserId == null);
            }

            return new ResultDto<bool>
            {
                Data = isExist,
                IsSuccess = true
            };
        }
    }
}

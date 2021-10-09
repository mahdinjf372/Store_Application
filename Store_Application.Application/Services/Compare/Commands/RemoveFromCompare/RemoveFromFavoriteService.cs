using System;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Compare.Commands.RemoveFromCompare
{
    public class RemoveFromFavoriteService : IRemoveFromFavoriteService
    {
        private readonly IDataBaseContext _db;
        public RemoveFromFavoriteService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int productId, Guid browserId, int? userId = null)
        {
            Domain.Entities.Compare.Compare compare;

            if (userId != null)
            {
                compare = _db.Compares.SingleOrDefault(c => c.ProductId == productId && c.UserId == userId);
            }
            else
            {
                compare = _db.Compares.SingleOrDefault(c => c.ProductId == productId && c.BrowserId == browserId && c.UserId == null);
            }

            if (compare != null)
            {
                compare.isRemoved = true;
                compare.RemovedTime = DateTime.Now;
                
                _db.Compares.Update(compare);
                _db.SaveChanges();
            }

            return new ResultDto()
            {
                IsSuccess = true
            };
        }
    }
}
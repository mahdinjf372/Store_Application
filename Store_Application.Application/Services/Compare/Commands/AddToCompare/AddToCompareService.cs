using System;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Compare.Commands.AddToCompare
{
    public class AddToCompareService : IAddToCompareService
    {
        private readonly IDataBaseContext _db;
        public AddToCompareService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int productId, Guid browserId, int? userId = null)
        {
            bool isExist = false;
            if (userId != null)
            {
                isExist = _db.Compares.Any(c => c.ProductId == productId && c.UserId == userId);
            }
            else
            {
                isExist = _db.Compares.Any(c => c.ProductId == productId && c.BrowserId == browserId && c.UserId == null);
            }

            if (!isExist)
            {
                var compare = new Domain.Entities.Compare.Compare()
                {
                    InsertTime = DateTime.Now,
                    ProductId = productId,
                    UserId = userId,
                    BrowserId = browserId
                };

                _db.Compares.Add(compare);
                _db.SaveChanges();
            }

            return new ResultDto()
            {
                IsSuccess = true
            };
        }
    }
}
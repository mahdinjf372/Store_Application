using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Products.Queries.IsExistProduct
{
    public class isExistProductService : IisExistProductService
    {
        private readonly IDataBaseContext _db;
        public isExistProductService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(string title, int? productId=null)
        {
            bool isExist = false;
            if (productId==null)
            {
                isExist = _db.Products.Any(p => p.Title.Equals(title) && p.isRemoved == false);
            }
            else
            {
                isExist = _db.Products.Any(p => p.Title.Equals(title) && !p.isRemoved && !p.Id.Equals(productId));
            }

            return new ResultDto<bool>
            {
                Data = isExist,
                IsSuccess = true,
                Message = isExist ? "محصولی با این نام موجود می باشد" : "محصولی با این نام موجود نمی باشد"
            };
        }

        public ResultDto<bool> Execute(int id)
        {
            var isExist = _db.Products.Any(p => p.Id.Equals(id) && p.isRemoved == false);

            return new ResultDto<bool>
            {
                Data = isExist,
                IsSuccess = true,
                Message = isExist ? "محصولی با این شناسه موجود میباشد" : "محصولی با این شناسه موجود نمی باشد"
            };
        }
    }
}

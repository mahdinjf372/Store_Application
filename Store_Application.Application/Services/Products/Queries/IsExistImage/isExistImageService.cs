using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Products.Queries.IsExistImage
{
    public class isExistImageService : IisExistImageService
    {
        private readonly IDataBaseContext _db;
        public isExistImageService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int id)
        {
            var isExist = _db.ProductImages.Any(pi => pi.Id.Equals(id));

            return new ResultDto<bool>
            {
                Data = isExist,
                IsSuccess = true,
                Message = isExist ? "تصویری با این شناسه موجود میباشد" : "تصویری با این شناسه موجود نمی باشد"
            };
        }
    }
}

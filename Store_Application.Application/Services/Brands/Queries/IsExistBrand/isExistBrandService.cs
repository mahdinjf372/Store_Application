using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Brands.Queries.IsExistBrand
{
    public class isExistBrandService : IisExistBrandService
    {
        private readonly IDataBaseContext _db;
        public isExistBrandService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int id)
        {
            var res = _db.Brands.Any(c => c.Id.Equals(id));

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true,
                Message = "عملیات جستوجوی دیتابیس با موفقیت انجام شد"
            };
        }
    }
}

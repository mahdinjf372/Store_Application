using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Categories.Queries.IsExistCategory
{
    public class isExistCategoryService : IisExistCategoryService
    {
        private readonly IDataBaseContext _db;
        public isExistCategoryService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int id)
        {
            var res = _db.Categories.Any(c => c.Id.Equals(id));

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true,
                Message = "عملیات جستوجوی دیتابیس با موفقیت انجام شد"
            };
        }
    }
}

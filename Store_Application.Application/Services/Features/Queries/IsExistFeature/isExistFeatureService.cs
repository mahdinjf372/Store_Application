using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Features.Queries.IsExistFeature
{
    public class isExistFeatureService : IisExistFeatureService
    {
        private readonly IDataBaseContext _db;
        public isExistFeatureService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(string featureName)
        {
            var isExist = _db.Features.Any(f => f.Title.Equals(featureName));

            return new ResultDto<bool>
            {
                Data = isExist,
                IsSuccess = true,
                Message = isExist?"ویژگی با این نام موجود می باشد": "ویژگی با این نام موجود نمی باشد"
            };
        }

        public ResultDto<bool> Execute(int id)
        {
            var isExist = _db.Features.Any(f => f.Id.Equals(id));

            return new ResultDto<bool>
            {
                Data = isExist,
                IsSuccess = true,
                Message = isExist? "ویژکی با این شناسه موجود میباشد" : "ویژکی با این شناسه موجود نمی باشد"
            };
        }
    }
}

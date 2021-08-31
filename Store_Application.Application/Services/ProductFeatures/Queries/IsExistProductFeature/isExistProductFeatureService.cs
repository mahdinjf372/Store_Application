using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.ProductFeatures.Queries.IsExistProductFeature
{
    public class isExistProductFeatureService : IisExistProductFeatureService
    {
        private readonly IDataBaseContext _db;
        public isExistProductFeatureService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(RequestIsExistProductFeatureDto req)
        {
            var res = _db.ProductFeatures.Any(pf =>
                            pf.FeatureId.Equals(req.FeatureId) &&
                            pf.ProductId.Equals(req.ProductId) &&
                            pf.Value.Equals(req.Value) &&
                            !pf.isRemoved);

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true,
            };
        }

        public ResultDto<bool> Execute(int pfId)
        {
            var res = _db.ProductFeatures.Any(pf => pf.Id.Equals(pfId) && !pf.isRemoved);

            return new ResultDto<bool>
            {
                Data = res,
                IsSuccess = true
            };
        }
    }
}

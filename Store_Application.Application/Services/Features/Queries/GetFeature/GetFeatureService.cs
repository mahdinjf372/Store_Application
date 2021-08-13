using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Features.Queries.GetFeature
{
    public class GetFeatureService : IGetFeatureService
    {
        private IDataBaseContext _db;
        public GetFeatureService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetFeatureDto> Execute(int id)
        {
            var feature = _db.Features.Find(id);

            var res = new ResultDto<ResultGetFeatureDto>
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد"
            };

            if (feature != null)
            {
                res.Data = new ResultGetFeatureDto { Id = feature.Id, Title = feature.Title, Values = feature.Values };
            }
            else
            {
                res.Data = null;
            }

            return res;
        }
    }
}

using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Features.Queries.GetFeatureForAdmin
{
    public class GetFeatureForAdminService : IGetFeatureForAdminService
    {
        private IDataBaseContext _db;
        public GetFeatureForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetFeatureForAdminDto> Execute(int id)
        {
            var feature = _db.Features.Find(id);

            var res = new ResultDto<ResultGetFeatureForAdminDto>
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد"
            };

            if (feature != null)
            {
                res.Data = new ResultGetFeatureForAdminDto { Id = feature.Id, Title = feature.Title, Values = feature.Values };
            }
            else
            {
                res.Data = null;
            }

            return res;
        }
    }
}

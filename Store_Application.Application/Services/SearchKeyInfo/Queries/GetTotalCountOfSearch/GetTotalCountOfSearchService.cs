using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace Store_Application.Application.Services.SearchKeyInfo.Queries.GetTotalCountOfSearch
{
    public class GetTotalCountOfSearchService : IGetTotalCountOfSearchService
    {
        private readonly IDataBaseContext _db;
        public GetTotalCountOfSearchService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<long> Execute()
        {
            var res = _db.SearchKeysInfo.LongCount();

            return new ResultDto<long>
            {
                Data = res,
                IsSuccess = true
            };
        }
    }
}

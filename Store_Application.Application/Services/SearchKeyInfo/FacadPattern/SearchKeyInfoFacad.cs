using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.SearchKeyInfo.Commands.AddSearchKeyInfo;
using Store_Application.Application.Services.SearchKeyInfo.Queries.GetTotalCountOfSearch;

namespace Store_Application.Application.Services.SearchKeyInfo.FacadPattern
{
    public class SearchKeyInfoFacad : ISearchKeyInfoFacad
    {
        private readonly IDataBaseContext _db;
        public SearchKeyInfoFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IAddSearchKeyInfoService _addSearchKeyInfoService;
        public IAddSearchKeyInfoService AddSearchKeyInfoService
        {
            get
            {
                return _addSearchKeyInfoService ??= new AddSearchKeyInfoService(_db);
            }
        }

        private IGetTotalCountOfSearchService _getTotalCountOfSearchService;
        public IGetTotalCountOfSearchService GetTotalCountOfSearchService
        {
            get
            {
                return _getTotalCountOfSearchService ??= new GetTotalCountOfSearchService(_db);
            }
        }

    }
}

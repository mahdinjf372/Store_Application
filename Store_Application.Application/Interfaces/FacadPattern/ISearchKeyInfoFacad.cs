using Store_Application.Application.Services.SearchKeyInfo.Commands.AddSearchKeyInfo;
using Store_Application.Application.Services.SearchKeyInfo.Queries.GetTotalCountOfSearch;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface ISearchKeyInfoFacad
    {
        IAddSearchKeyInfoService AddSearchKeyInfoService { get; }
        IGetTotalCountOfSearchService GetTotalCountOfSearchService { get; }
    }
}

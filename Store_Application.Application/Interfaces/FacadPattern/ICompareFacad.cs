using Store_Application.Application.Services.Compare.Commands.AddToCompare;
using Store_Application.Application.Services.Compare.Commands.MergeCompare;
using Store_Application.Application.Services.Compare.Commands.RemoveFromCompare;
using Store_Application.Application.Services.Compare.Queries.GetCompareList;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface ICompareFacad
    {
        IAddToCompareService AddToCompareService { get; }
        IRemoveFromFavoriteService RemoveFromFavoriteService { get; }
        IMergeCompareService MergeCompareService { get; }
        IGetCompareListService GetCompareListService { get; }
    }
}
using Store_Application.Application.Services.Advertinig.Commands.Add;
using Store_Application.Application.Services.Advertinig.Commands.Delete;
using Store_Application.Application.Services.Advertinig.Commands.Edit;
using Store_Application.Application.Services.Advertinig.Queries.GetAdvertisings;
using Store_Application.Application.Services.Advertinig.Queries.GetAdvertisingsForAdmin;
using Store_Application.Application.Services.Advertinig.Queries.IsExist;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IAdvertisingFacad
    {
        IGetAdvertisingsForAdminService GetAdvertisingsForAdminService { get; }
        IGetAdvertisingsService GetAdvertisingsService { get; }
        IAddAdvertisingService AddAdvertisingService { get; }
        IEditAdvertisingService EditAdvertisingService { get; }
        IisExistAdvertisingService IsExistAdvertisingService { get; }
        IDeleteAdvertisingService DeleteAdvertisingService { get; }
    }
}

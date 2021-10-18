using AutoMapper;
using EndPoint.WebSite.Areas.Admin.Models.Advertising.Create;
using EndPoint.WebSite.Areas.Admin.Models.Advertising.Edit;
using EndPoint.WebSite.Areas.Admin.Models.Advertising.LoadAdvertisings;
using Store_Application.Application.Services.Advertinig.Commands.Add;
using Store_Application.Application.Services.Advertinig.Commands.Edit;
using Store_Application.Application.Services.Advertinig.Queries.GetAdvertisingsForAdmin;

namespace EndPoint.WebSite.Mapper.Admin
{
    public class AdvertisingControllerMappers : Profile
    {
        public AdvertisingControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<GetAdvertisingForAdminDto, AdvertisingViewModel>();

            CreateMap<CreateViewModel, RequestAddAdvertisingDto>();

            CreateMap<EditViewModel, RequestEditAdvertisingDto>();

        }
    }
}

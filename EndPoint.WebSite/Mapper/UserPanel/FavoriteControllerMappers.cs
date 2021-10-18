using AutoMapper;
using EndPoint.WebSite.Areas.UserPanel.Models.Favorite.Index;
using Store_Application.Application.Services.Favorite.Queries.GetFavoriteList;

namespace EndPoint.WebSite.Mapper.UserPanel
{
    public class FavoriteControllerMappers : Profile
    {
        public FavoriteControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<ResultGetFavoriteListDto, FavoriteListViewModel>();
        }
    }
}

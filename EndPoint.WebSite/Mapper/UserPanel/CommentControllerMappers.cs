using AutoMapper;
using EndPoint.WebSite.Areas.UserPanel.Models.Account.Index;
using EndPoint.WebSite.Areas.UserPanel.Models.Comment.Index;
using Store_Application.Application.Services.Comment.Queries.GetUserComments;
using Store_Application.Application.Services.Users.Queries.GetUserByIdForUserPanel;

namespace EndPoint.WebSite.Mapper.UserPanel
{
    public class CommentControllerMappers : Profile
    {
        public CommentControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<ResultGetUserCommentDto, UserCommentViewModel>();
            CreateMap<ProductDto, ProductViewModel>();

        }
    }
}

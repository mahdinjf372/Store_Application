using AutoMapper;
using Store_Application.Application.Services.Comment.Commads.AddComment;
using Store_Application.Application.Services.Comment.Queries.GetComments;

namespace EndPoint.WebSite.Mapper.Site
{
    public class CommentControllerMappers : Profile
    {
        public CommentControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<ResultGetCommentsDto, Models.Comment.LoadComments.LoadCommentsViewModel>()
                .ForMember(outer => outer.UserId, opt => opt.MapFrom(inner => inner.User.Id))
                .ForMember(outer => outer.Username, opt => opt.MapFrom(inner => inner.User.Username));

            CreateMap<Models.Comment.Add.AddCommentViewModel, RequestAddCommentDto>()
                .ForMember(outer => outer.Title, opt => opt.MapFrom(inner => inner.Title.Trim()))
                .ForMember(outer => outer.Text, opt => opt.MapFrom(inner => inner.Text.Trim()))
                .ForMember(outer => outer.IRecomended, opt => opt.MapFrom(inner => inner.IRecommend == "بله" ? true : false));

        }
    }
}

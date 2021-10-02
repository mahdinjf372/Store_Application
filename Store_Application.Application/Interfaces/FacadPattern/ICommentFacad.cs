using Store_Application.Application.Services.Comment.Commads.AddComment;
using Store_Application.Application.Services.Comment.Commads.DislikeComment;
using Store_Application.Application.Services.Comment.Commads.LikeComment;
using Store_Application.Application.Services.Comment.Queries.GetComments;
using Store_Application.Application.Services.Comment.Queries.IsExistComment;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface ICommentFacad
    {
        IAddCommentService AddCommentService { get; }
        IGetCommentsService GetCommentsService { get; }
        ILikeCommentService LikeCommentService { get; }
        IDislikeCommentService DislikeCommentService { get; }
        IisExistCommentService IsExistCommentService { get; }

    }
}

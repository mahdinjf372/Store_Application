using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Comment.Commads.LikeComment
{
    public interface ILikeCommentService
    {
        ResultDto<ResultLikeCommentDto> Execute(RequestLikeCommentDto req);
    }
}

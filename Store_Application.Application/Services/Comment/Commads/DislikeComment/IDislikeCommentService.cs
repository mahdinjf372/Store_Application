using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Comment.Commads.DislikeComment
{
    public interface IDislikeCommentService
    {
        ResultDto<ResultDislikeCommentDto> Execute(RequestDislikeCommentDto req);
    }
}

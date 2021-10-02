using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Comment;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Comment.Commads.AddComment
{
    public interface IAddCommentService
    {
        ResultDto Execute(RequestAddCommentDto req);
    }
}

using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Comment.Commads.RemoveComment
{
    public interface IRemoveCommentService
    {
        ResultDto Execute(int userId, int commentId);
    }
}

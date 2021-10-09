using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Comment.Commads.ChangeStatusForAdmin
{
    public interface IChangeStatusForAdminService
    {
        ResultDto Execute(int commentId);
    }
}

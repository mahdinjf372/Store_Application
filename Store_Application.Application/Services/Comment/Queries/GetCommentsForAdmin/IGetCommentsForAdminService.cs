using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Comment.Queries.GetCommentsForAdmin
{
    public interface IGetCommentsForAdminService
    {
        ResultDto<ResultGetCommentsForAdminDto> Execute(RequestGetCommentsForAdminDto req);
    }
}

using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.GetUsersForAdmin
{
    public interface IGetUsersForAdminService
    {
        ResultDto<ResultGetUsersForAdminDto> Execute(RequestGetUsersForAdminDto req);
    }
}

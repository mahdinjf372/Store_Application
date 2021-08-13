using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        ResultDto<ResultGetUsersDto> Execute(RequestGetUsersDto req);
    }
}

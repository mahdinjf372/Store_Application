using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.LoginUser
{
    public interface ILoginUserService
    {
        ResultDto<ResultLoginUserDto> Execute(RequestLoginUserDto req);
    }
}

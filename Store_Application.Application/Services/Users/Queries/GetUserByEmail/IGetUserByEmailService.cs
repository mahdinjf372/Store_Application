using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.GetUserByEmail
{
    public interface IGetUserByEmailService
    {
        ResultDto<ResultGetUserbyEmailDto> Execute(string email);
    }
}

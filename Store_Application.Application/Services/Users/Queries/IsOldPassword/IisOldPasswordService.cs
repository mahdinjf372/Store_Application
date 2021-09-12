using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.IsOldPassword
{
    public interface IisOldPasswordService
    {
        ResultDto<bool> Execute(int userId, string password);
    }
}

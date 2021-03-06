using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.GetUserByIdForAdmin
{
    public interface IGetUserByIdForAdminService
    {
        ResultDto<ResultGetUserByIdForAdminDto> Execute(int id);    
    }

}

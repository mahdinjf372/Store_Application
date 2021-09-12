using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Users.Queries.GetUserByIdForUserPanel
{
    public interface IGetUserByIdForUserPanelService
    {
        ResultDto<ResultGetUserByIdForUserPanelDto> Execute(int id);    
    }

}

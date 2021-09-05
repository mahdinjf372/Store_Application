using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Sliders.Queries.GetSlidersForAdmin
{
    public interface IGetSlidersForAdminService
    {
        ResultDto<List<ResultGetSlidersForAdminDto>> Execute();
    }
}

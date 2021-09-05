using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.MainSlider.Queries.GetSlidesForAdmin
{
    public interface IGetSlidesForAdminService
    {
        ResultDto<List<ResultGetSlidesForAdminDto>> Execute();
    }
}

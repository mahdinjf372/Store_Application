using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Sliders.Queries.GetSliders
{
    public interface IGetSlidersService
    {
        ResultDto<List<ResultGetSlidersDto>> Execute();
    }
}

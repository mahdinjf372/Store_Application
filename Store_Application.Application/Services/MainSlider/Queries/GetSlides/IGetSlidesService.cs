using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.MainSlider.Queries.GetSlides
{
    public interface IGetSlidesService
    {
        ResultDto<List<ResultGetSlidesDto>> Execute();
    }
}

using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Features.Queries.GetFeatures
{
    public interface IGetFeaturesService
    {
        ResultDto<List<ResultGetFeaturesDto>> Execute();
    }
}

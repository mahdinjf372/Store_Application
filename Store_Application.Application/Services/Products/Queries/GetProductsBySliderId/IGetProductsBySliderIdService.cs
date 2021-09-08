using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using Store_Application.Domain.Enums;

namespace Store_Application.Application.Services.Products.Queries.GetProductsBySliderId
{
    public interface IGetProductsBySliderIdService
    {
        ResultDto<ResultGetProductsBySliderIdDto> Execute(Domain.Enums.ProductSliders sliderId);
    }
}

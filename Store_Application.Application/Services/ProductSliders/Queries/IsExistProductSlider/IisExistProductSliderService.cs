using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductSliders.Queries.IsExistProductSlider
{
    public interface IisExistProductSliderService
    {
        ResultDto<bool> Execute(int productId, int sliderId);
    }
}

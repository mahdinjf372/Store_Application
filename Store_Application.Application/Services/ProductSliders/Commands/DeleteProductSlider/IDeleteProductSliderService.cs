using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductSliders.Commands.DeleteProductSlider
{
    public interface IDeleteProductSliderService
    {
        ResultDto Execute(RequestDeleteProductSliderDto req);
    }
}

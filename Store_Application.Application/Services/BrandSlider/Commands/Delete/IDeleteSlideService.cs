using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.BrandSlider.Commands.Delete
{
    public interface IDeleteSlideService
    {
        ResultDto Execute(int id);

    }
}

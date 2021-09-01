using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Site;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.MainSlider.Commands.Edit
{
    public interface IEditSlideService
    {
        ResultDto Execute(RequestEditSlideDto req);
    }
}

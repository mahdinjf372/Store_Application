using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Site;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.MainSlider.Commands.Delete
{
    public interface IDeleteSlideService
    {
        ResultDto Execute(int id);
    }
}

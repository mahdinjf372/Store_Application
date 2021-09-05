using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Advertinig.Commands.Edit
{
    public interface IEditAdvertisingService
    {
        ResultDto Execute(RequestEditAdvertisingDto req);
    }
}

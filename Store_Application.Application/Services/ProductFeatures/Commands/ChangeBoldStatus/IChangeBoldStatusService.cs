using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.ProductFeatures.Commands.ChangeBoldStatus
{
    public interface IChangeBoldStatusService
    {
        ResultDto Execute(int pfId);
    }
}

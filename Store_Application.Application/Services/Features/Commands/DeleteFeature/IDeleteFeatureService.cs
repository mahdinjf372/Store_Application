using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Features.Commands.DeleteFeature
{
    public interface IDeleteFeatureService
    {
        ResultDto Execute(int id);
    }
}

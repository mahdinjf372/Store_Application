using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Features.Commands.EditFeature
{
    public interface IEditFeatureService
    {
        ResultDto Execute(int id, string featureName);
    }
}

using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Brands.Queries.IsExistBrand
{
    public interface IisExistBrandService
    {
        ResultDto<bool> Execute(int id);
    }
}

using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Queries.IsExistProduct
{
    public interface IisExistProductService
    {
        ResultDto<bool> Execute(string title, int? productId = null);
        ResultDto<bool> Execute(int id);
    }
}

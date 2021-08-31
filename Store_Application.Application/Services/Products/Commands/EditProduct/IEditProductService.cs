using Store_Application.Common.ViewModels;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Commands.EditProduct
{
    public interface IEditProductService
    {
        ResultDto Execute(RequestEditProductDto req);
    }
}

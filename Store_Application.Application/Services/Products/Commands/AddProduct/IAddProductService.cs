using Store_Application.Common.ViewModels;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Commands.AddProduct
{
    public interface IAddProductService
    {
        ResultDto Execute(RequestAddProductDto req);
    }
}

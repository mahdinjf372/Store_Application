using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Carts.Commands.AddProductToCart
{
    public interface IAddProductToCartService
    {
        ResultDto Execute(RequestAddProductToCartDto req);
    }
}

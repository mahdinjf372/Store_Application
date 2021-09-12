using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Carts.Commands.DeleteProduct
{
    public interface IDeleteProductService
    {
        ResultDto<bool> Execute(int ProductId, int userId, Guid BrowserId);
    }

}

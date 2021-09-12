using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Carts.Queries.IsExistCartByUserId
{
    public interface IisExistCartByUserIdService
    {
        ResultDto<bool> Execute(int userId);
    }
}

using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Favorite.Queries.IsFavoriteProduct
{
    public interface IisFavoriteProductService
    {
        ResultDto<bool> Execute(int productId, Guid browserId, int? userId=null);
    }
}

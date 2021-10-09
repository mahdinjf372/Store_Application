using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Favorite.Queries.GetFavoriteList
{
    public interface IGetFavoriteListService
    {
        ResultDto<List<ResultGetFavoriteListDto>> Execute(Guid browserId, int? userId = null);
    }
}

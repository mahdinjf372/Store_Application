using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Favorite.Commands.MergeFavoriteLists
{
    public interface IMergeFavoriteListService
    {
        ResultDto Execute(int userId, Guid browserId);
    }
}

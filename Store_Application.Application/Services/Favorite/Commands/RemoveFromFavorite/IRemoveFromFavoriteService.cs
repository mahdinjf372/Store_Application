using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Favorite.Commands.RemoveFromFavorite
{
    public interface IRemoveFromFavoriteService
    {
        ResultDto Execute(RequestRemoveProductFromFavoriteDto req);
    }
}

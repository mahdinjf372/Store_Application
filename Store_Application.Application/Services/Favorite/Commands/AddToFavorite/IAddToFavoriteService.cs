using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Favorite.Commands.AddToFavorite
{
    public interface IAddToFavoriteService
    {
        ResultDto Execute(RequestAddProductToFavoriteDto req);
    }
}

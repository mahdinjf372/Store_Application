using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Queries.GetGalleryImagesForAdmin
{
    public interface IGetGalleryImagesForAdminService
    {
        ResultDto<List<ResultGetGalleryImagesForAdminDto>> Execute(int productId);
    }
}

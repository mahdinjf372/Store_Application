using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Queries.GetGalleryImages
{
    public interface IGetGalleryImagesService
    {
        ResultDto<List<ResultGetGalleryImagesDto>> Execute(int productId);
    }
}

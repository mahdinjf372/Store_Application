using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Commands.AddGalleryImage
{
    public interface IAddGalleryImageService
    {
        ResultDto Execute(requestAddGalleryImageDto req);
        ResultDto Execute(List<requestAddGalleryImageDto> reqs);
    }
}

using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Products.Queries.GetGalleryImage
{
    public class GetGalleryImageService : IGetGalleryImageService
    {
        private readonly IDataBaseContext _db;
        public GetGalleryImageService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetGalleryImage> Execute(int id)
        {
            try
            {
                var image = _db.ProductImages.Find(id);

                var res = new ResultGetGalleryImage
                {
                    Id = image.Id,
                    Name = image.Name
                };

                return new ResultDto<ResultGetGalleryImage>
                {
                    Data = res,
                    IsSuccess = true,
                    Message = "تصویر با موفقیت یافت شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto<ResultGetGalleryImage>
                {
                    Data = null,
                    IsSuccess = true,
                    Message = "عملیات جست و جو با شکست مواجه شد"
                };
            }
        }
    }
}

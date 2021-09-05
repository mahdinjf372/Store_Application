using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Products.Queries.GetGalleryImageForAdmin
{
    public class GetGalleryImageForAdminService : IGetGalleryImageForAdminService
    {
        private readonly IDataBaseContext _db;
        public GetGalleryImageForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetGalleryImageForAdminDto> Execute(int id)
        {
            try
            {
                var image = _db.ProductImages.Find(id);

                var res = new ResultGetGalleryImageForAdminDto
                {
                    Id = image.Id,
                    Name = image.Name
                };

                return new ResultDto<ResultGetGalleryImageForAdminDto>
                {
                    Data = res,
                    IsSuccess = true,
                    Message = "تصویر با موفقیت یافت شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto<ResultGetGalleryImageForAdminDto>
                {
                    Data = null,
                    IsSuccess = true,
                    Message = "عملیات جست و جو با شکست مواجه شد"
                };
            }
        }
    }
}

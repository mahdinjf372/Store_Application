using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Products.Queries.GetGalleryImages
{
    public class GetGalleryImagesService : IGetGalleryImagesService
    {
        private readonly IDataBaseContext _db;
        public GetGalleryImagesService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetGalleryImagesDto>> Execute(int productId)
        {
            try
            {
                var res = _db.ProductImages
                    .Where(pi => pi.ProductId.Equals(productId) && !pi.IsMainImage && !pi.isRemoved)
                    .Select(pi=> new ResultGetGalleryImagesDto
                    {
                        Id = pi.Id,
                        Name = pi.Name
                    })
                    .ToList();

                return new ResultDto<List<ResultGetGalleryImagesDto>>
                {
                    Data = res,
                    Message = "گالری با موفقیت واکشی شد",
                    IsSuccess = true
                };

            }
            catch (Exception)
            {
                return new ResultDto<List<ResultGetGalleryImagesDto>>
                {
                    Data = null,
                    Message = "واکشی گالری تصاویر با شکست مواجه شد",
                    IsSuccess = false
                };
            }
        }
    }
}

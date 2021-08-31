using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Products.Commands.AddGalleryImage
{
    public class AddGalleryImageService : IAddGalleryImageService
    {
        private readonly IDataBaseContext _db;
        public AddGalleryImageService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(requestAddGalleryImageDto req)
        {
            try
            {
                _db.ProductImages.Add(new ProductImage
                {
                    Name = req.Name,
                    IsMainImage = false,
                    InsertTime = DateTime.Now,
                    isRemoved = false,
                    ProductId = req.ProductId
                });
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "تصویر با موفقیت ثبت شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ثبت تصویر با شکست مواجه شد"
                };
            }
        }

        public ResultDto Execute(List<requestAddGalleryImageDto> reqs)
        {
            try
            {
                var productImages = reqs.Select(pi=> new ProductImage
                {
                    Name = pi.Name,
                    IsMainImage = false,
                    InsertTime = DateTime.Now,
                    isRemoved = false,
                    ProductId = pi.ProductId
                });

                _db.ProductImages.AddRange(productImages);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "تصوایر با موفقیت ثبت شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ثبت تصوایر با شکست مواجه شد"
                };
            }
        }
    }
}

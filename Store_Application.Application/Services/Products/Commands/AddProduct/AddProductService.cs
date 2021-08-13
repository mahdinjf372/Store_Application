using Store_Application.Common.ViewModels;
using System;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Domain.Entities.Product;
using System.Collections.Generic;

namespace Store_Application.Application.Services.Products.Commands.AddProduct
{
    public class AddProductService : IAddProductService
    {
        private IDataBaseContext _db;
        public AddProductService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddProductDto req)
        {
            var res = new ResultDto();
            if (_db.Products.Any(p => p.Title.Equals(req.Title)))
            {
                res.IsSuccess = false;
                res.Message = "محصولی با این تیتر موجود میباشد";
            }
            else
            {
                Product product = new Product()
                {
                    BrandId = req.BrandId,
                    CategoryId = req.CategoryId,
                    Description = req.Description,
                    DiscountAmount = req.DiscountAmount,
                    Displayed = req.Displayed,
                    InsertTime = DateTime.Now,
                    Inventory = req.Inventory,
                    Price = req.Price,
                    ShortDescription = req.ShortDescription,
                    Title = req.Title,
                    isRemoved = false,
                };

                _db.Products.Add(product);
                _db.SaveChanges();

                List<ProductImage> images = req.Images.Select(i => new ProductImage
                {
                    Name = i.Name,
                    IsMainImage = i.isMainImage,
                    InsertTime = DateTime.Now,
                    ProductId = product.Id,
                    
                }).ToList();

                _db.ProductImages.AddRange(images);
                _db.SaveChanges();

                res.IsSuccess = true;
                res.Message = "محصول با موفقیت ثبت شد";
            }

            return res;
        }
    }
}

using Store_Application.Common.ViewModels;
using System;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Domain.Entities.Product;
using System.Collections.Generic;
using System.IO;
using Store_Application.Common.Security;
using Microsoft.EntityFrameworkCore;

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
            
            var des = DecodeDescriptionMedia(req.Description);

            Product product = new Product()
            {
                BrandId = req.BrandId,
                CategoryId = req.SubGroupId,
                Description = des,
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

            List<Image> images = SaveProductImages(req);

            List<ProductImage> productimages = images.Select(i => new ProductImage
            {
                Name = i.Name,
                IsMainImage = i.isMainImage,
                InsertTime = DateTime.Now,
                ProductId = product.Id,

            }).ToList();

            var tags = MappingTags(req.Tags, product.Id,req.SubGroupId);

            var pr = _db.Products.Find(product.Id);
            pr.TagsForSearch = string.Join("-", tags.Select(t => t.Title).ToList());

            _db.Tags.AddRange(tags);

            _db.ProductImages.AddRange(productimages);
            _db.SaveChanges();

            res.IsSuccess = true;
            res.Message = "محصول با موفقیت ثبت شد";
            return res;
        }

        private List<Image> SaveProductImages(RequestAddProductDto req)
        {
            List<Image> images = new List<Image>();

            //Main image
            if (req.MainImage != null && req.MainImage.OpenReadStream().IsImage())
            {
                var name = Guid.NewGuid() + Path.GetExtension(req.MainImage.FileName);
                images.Add(new Image
                {
                    Name = name,
                    isMainImage = true
                });
                string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/page-single-product/product-img",
                    name);
                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    req.MainImage.CopyTo(stream);
                }
            }

            //gallery images
            if (req.GalleryImages != null)
            {
                foreach (var image in req.GalleryImages)
                {
                    if (image.OpenReadStream().IsImage())
                    {
                        var name = Guid.NewGuid() + Path.GetExtension(image.FileName);
                        images.Add(new Image
                        {
                            Name = name,
                            isMainImage = false
                        });
                        string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/page-single-product/product-img/",
                            name);
                        using (var stream = new FileStream(savePath, FileMode.Create))
                        {
                            image.CopyTo(stream);
                        }
                    }
                }
            }

            return images;
        }

        private string DecodeDescriptionMedia(string des)
        {
            while (des.Contains("<img src=\"data:image"))
            {
                //encode images
                var imageIndex = des.IndexOf("<img src=\"data:image/");
                var startFromImage = des.Substring(imageIndex);

                var dataindex = startFromImage.IndexOf("data:");
                var startFromData = startFromImage.Substring(dataindex);

                var startB64Index = startFromData.IndexOf(",") + 1;
                var base64str = startFromData.Substring(startB64Index);

                var endIndex = base64str.IndexOf('"');
                base64str = base64str.Substring(0, endIndex);

                var imgFormat = startFromData.Substring(11, 10).Split(";")[0];
                var name = Guid.NewGuid() + "." + imgFormat;

                des = des.Substring(0, imageIndex + 10);
                var description = des + "/images/page-single-product/tab-content/" + name;
                var endB64Index = startFromData.IndexOf('"');
                des = startFromData.Substring(endB64Index);
                des = description + des;

                byte[] bytes = Convert.FromBase64String(base64str);

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    System.Drawing.Image pic = System.Drawing.Image.FromStream(ms);
                    var savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/page-single-product/tab-content/", name);
                    pic.Save(savePath);
                }

            }

            //encode Elements
            des = des.Replace("<figure class=\"", "<div class=\"content-expert-img mr-auto ml-auto ");
            des = des.Replace("</figure>", "</div>");
            des = des.Replace("><img src=\"/images/page-single-product/tab-content/", "><img class=\"w-100\" src=\"/images/page-single-product/tab-content/");
            des = des.Replace("<h3", "<h3 class=\"content-expert-title\"");
            des = des.Replace("<p", "<p class=\"content-expert-text\"");

            return des;
        }

        private List<Tag> MappingTags(string inputTags,int productId,int categoryId)
        {
            var tags = inputTags.Split("-").ToList();
            var res = new List<Tag>();

            var category = _db.Categories.Include(c => c.ParentCategory).ThenInclude(c => c.ParentCategory).Single(c => c.Id == categoryId);
            tags.Add(category.Title);
            tags.Add(category.ParentCategory.Title);
            tags.Add(category.ParentCategory.ParentCategory.Title);

            for (int i = 0; i < tags.Count(); i++)
            {
                tags[i] = tags[i].Trim();

                while (tags[i].Contains(" "))
                {
                    tags[i] = tags[i].Replace(" ", "_");
                }

                while (tags[i].Contains("__"))
                {
                    tags[i] = tags[i].Replace("__", "_");
                }

            }

            tags = tags.Distinct().ToList();

            foreach (var tag in tags)
            {
                if (string.IsNullOrEmpty(tag))
                    continue;

                res.Add(new Tag
                {
                    InsertTime = DateTime.Now,
                    ProductId = productId,
                    Title = tag
                });
            }

            return res;
        }
    }
}
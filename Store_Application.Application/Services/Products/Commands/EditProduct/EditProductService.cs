using Store_Application.Common.ViewModels;
using System;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Domain.Entities.Product;
using System.Collections.Generic;
using System.IO;
using Store_Application.Common.Security;
using Microsoft.EntityFrameworkCore;

namespace Store_Application.Application.Services.Products.Commands.EditProduct
{
    public class EditProductService : IEditProductService
    {
        private IDataBaseContext _db;
        public EditProductService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestEditProductDto req)
        {
            var res = new ResultDto();
            var product = _db.Products.Find(req.Id);

            var des = DecodeDescriptionMedia(req.Description);

            UpdateTagsToDb(req);

            product.TagsForSearch = string.Join("-", _db.Tags.Where(t => t.ProductId == req.Id).Select(t => t.Title).ToList());
            product.BrandId = req.BrandId;
            product.CategoryId = req.SubGroupId;
            product.Description = des;
            product.DiscountAmount = req.DiscountAmount;
            product.Displayed = req.Displayed;
            product.UpdateTime = DateTime.Now;
            product.Inventory = req.Inventory;
            product.Price = req.Price;
            product.ShortDescription = req.ShortDescription;
            product.Title = req.Title;
            product.isRemoved = false;

            _db.Products.Update(product);
            _db.SaveChanges();

            UpdateMainImageToDb(req);

            res.IsSuccess = true;
            res.Message = "محصول با موفقیت ثبت شد";
            return res;
        }

        private Image SaveProductImages(RequestEditProductDto req)
        {
            Image image = new Image();
            if (req.MainImage.OpenReadStream().IsImage())
            {
                var name = Guid.NewGuid() + Path.GetExtension(req.MainImage.FileName);

                image.Name = name;
                image.isMainImage = true;

                string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/page-single-product/product-img",
                    name);
                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    req.MainImage.CopyTo(stream);
                }

                string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/page-single-product/product-img",
                    req.Image);

                File.Delete(deletePath);
            }

            return image;
        }

        private string DecodeDescriptionMedia(string des)
        {
            while (des.Contains("<img src=\"data:image"))
            {
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
            des = des.Replace("<p", "<p class=\"content-expert-title\"");


            return des;

        }

        private List<Tag> MappingTags(string inputTags, int productId, int categoryId)
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

        private void UpdateMainImageToDb(RequestEditProductDto req)
        {
            if (req.MainImage != null)
            {
                var OldImgId = _db.ProductImages.SingleOrDefault(i => i.ProductId.Equals(req.Id) && i.IsMainImage && !i.isRemoved);
                OldImgId.isRemoved = true;
                OldImgId.RemovedTime = DateTime.Now;
                _db.ProductImages.Update(OldImgId);
                _db.SaveChanges();

                Image image = SaveProductImages(req);
                _db.ProductImages.Add(new ProductImage
                {
                    InsertTime = DateTime.Now,
                    IsMainImage = image.isMainImage,
                    Name = image.Name,
                    ProductId = req.Id,
                });
                _db.SaveChanges();

            }
        }

        private void UpdateTagsToDb(RequestEditProductDto req)
        {
            var newTags = MappingTags(req.Tags, req.Id, req.SubGroupId);

            var oldTags = _db.Tags.Where(t => t.ProductId == req.Id).ToList();

            foreach (var oldTag in oldTags)
            {
                var isExist = newTags.FirstOrDefault(t => t.Title == oldTag.Title);
                if (isExist != null)
                {
                    newTags.Remove(isExist);
                }
                else
                {
                    oldTag.isRemoved = true;
                    oldTag.RemovedTime = DateTime.Now;
                    _db.Tags.Update(oldTag);
                    _db.SaveChanges();
                }
            }

            foreach (var tag in newTags)
            {
                _db.Tags.Add(new Tag
                {
                    InsertTime = DateTime.Now,
                    ProductId = req.Id,
                    Title = tag.Title
                });
                _db.SaveChanges();
            }
        }
    }
}
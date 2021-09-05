using Microsoft.AspNetCore.Http;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Extentions;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Site;
using System;
using System.IO;

namespace Store_Application.Application.Services.Advertinig.Commands.Add
{
    public class AddAdvertisingService : IAddAdvertisingService
    {
        private readonly IDataBaseContext _db;
        public AddAdvertisingService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddAdvertisingDto req)
        {
            try
            {
                var ad = new Advertising()
                {
                    Description = req.Description,
                    InsertTime = DateTime.Now,
                    Place = req.Place,
                    Title = req.Title.Trim(),
                    StartDate = req.StartDate.ToMiladi(),
                    EndDate = req.EndDate.ToMiladi(),
                    LinkTo = req.LinkTo,
                    ImageName = SaveImage(req.Image)
                };

                _db.Advertisings.Add(ad);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "بنر با موفقیت ثبت شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ثبت بنر با شکست مواجه شد"
                };
            }
        }

        private string SaveImage(IFormFile image)
        {
            var ImageName = Generator.GetImageName() + Path.GetExtension(image.FileName);
            string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "adplacement",
                ImageName);
            using (var stream = new FileStream(savePath, FileMode.Create))
            {
                image.CopyTo(stream);
            }

            return ImageName;
        }
    }
}

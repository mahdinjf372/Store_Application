using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Extentions;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using System;
using System.IO;

namespace Store_Application.Application.Services.MainSlider.Commands.Add
{
    public class AddSlideService : IAddSlideService
    {
        private readonly IDataBaseContext _db;
        public AddSlideService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddSlideDto req)
        {
            try
            {
                req.ImageName = "default.jpg";

                if (string.IsNullOrEmpty(req.LinkTo))
                {
                    req.LinkTo = "http://";
                }

                var slide = new Domain.Entities.Site.MainSlider()
                {
                    InsertTime = DateTime.Now,
                    ImageName = SaveImage(req),
                    LinkTo = req.LinkTo,
                    Title = req.Title
                };

                _db.MainSlides.Add(slide);
                _db.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "اسلاید با موفقیت افزوده شد"
                };
            }
            catch (Exception e)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "افزودن اسلاید با شکست مواجه شد"
                };
            }
        }

        private string SaveImage(RequestAddSlideDto req)
        {
            if (req.Image != null && req.Image.OpenReadStream().IsImage())
            {
                req.ImageName = Generator.GetImageName() + Path.GetExtension(req.Image.FileName);
                string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "slider-main",
                    req.ImageName);
                using (var stream = new FileStream(savePath, FileMode.Create))
                {
                    req.Image.CopyTo(stream);
                }
            }
            return req.ImageName;
        }
    }
}

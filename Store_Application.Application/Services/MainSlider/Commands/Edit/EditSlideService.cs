using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Extentions;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using System;
using System.IO;

namespace Store_Application.Application.Services.MainSlider.Commands.Edit
{
    public class EditSlideService : IEditSlideService
    {
        private readonly IDataBaseContext _db;
        public EditSlideService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestEditSlideDto req)
        {
            try
            {
                var slide = _db.MainSlides.Find(req.Id);

                if (string.IsNullOrEmpty(req.LinkTo))
                {
                    req.LinkTo = "http://";
                }

                if (req.Image != null)
                {
                    slide.ImageName = SaveImage(req);
                }

                slide.Title = req.Title;
                slide.UpdateTime = DateTime.Now;

                _db.MainSlides.Update(slide);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "اسلاید با موفقیت ویرایش شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ویرایش اسلاید با شکست مواجه شد"
                };
            }
        }

        private string SaveImage(RequestEditSlideDto req)
        {
            if (req.Image != null && req.Image.OpenReadStream().IsImage())
            {

                if (req.ImageName != "default.jpg")
                {
                    string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "slider-main",
                        req.ImageName);
                    if (System.IO.File.Exists(deletePath))
                        System.IO.File.Delete(deletePath);
                }


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

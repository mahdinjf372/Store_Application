using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Extentions;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using System;
using System.IO;

namespace Store_Application.Application.Services.Advertinig.Commands.Edit
{
    public class EditAdvertisingService : IEditAdvertisingService
    {
        private readonly IDataBaseContext _db;
        public EditAdvertisingService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestEditAdvertisingDto req)
        {
            try
            {
                var ad = _db.Advertisings.Find(req.Id);
                ad.Title = req.Title.Trim();
                ad.Description = req.Description;
                ad.LinkTo = req.LinkTo;
                ad.StartDate = req.StartDate.ToMiladi();
                ad.EndDate = req.EndDate.ToMiladi();
                ad.Place = req.Place;
                ad.UpdateTime = DateTime.Now;

                if (req.Image != null)
                {
                    ad.ImageName = SaveImage(req);
                }

                _db.Advertisings.Update(ad);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "بنر با موفقیت ویرایش شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ویرایش بنر با شکست مواجه شد"
                };
            }
        }

        private string SaveImage(RequestEditAdvertisingDto req)
        {
            if (req.Image != null && req.Image.OpenReadStream().IsImage())
            {
                if (req.ImageName != "default.jpg")
                {
                    string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "adplacement",
                        req.ImageName);
                    if (System.IO.File.Exists(deletePath))
                        System.IO.File.Delete(deletePath);
                }


                req.ImageName = Generator.GetImageName() + Path.GetExtension(req.Image.FileName);
                string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "adplacement",
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

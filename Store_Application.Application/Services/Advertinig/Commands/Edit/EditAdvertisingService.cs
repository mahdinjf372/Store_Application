using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Extentions;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Enums;
using System;
using System.IO;
using System.Linq;

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
            string message;
            if (ConflictTemporalInterference(req.Id, req.StartDate, req.EndDate, req.Place, out message))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = message
                };
            }
            else
            {
                try
                {
                    DateTime endDate = req.EndDate;
                    endDate = endDate.AddHours(23);
                    endDate = endDate.AddMinutes(59);
                    endDate = endDate.AddSeconds(59);

                    DateTime startDate = req.StartDate;
                    startDate = startDate.AddHours(0);
                    startDate = startDate.AddMinutes(0);
                    startDate = startDate.AddSeconds(0);

                    var ad = _db.Advertisings.Find(req.Id);
                    ad.Title = req.Title.Trim();
                    ad.Description = req.Description;
                    ad.LinkTo = req.LinkTo;
                    ad.StartDate = startDate.ToMiladi();
                    ad.EndDate = endDate.ToMiladi();
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
        }

        private bool ConflictTemporalInterference(int id, DateTime start, DateTime end, AdvertisingPlaces place, out string message)
        {
            var _ads = _db.Advertisings.Where(a => a.Place.Equals(place) && !a.Id.Equals(id));

            var slide = _ads.SingleOrDefault(a => a.EndDate >= start.ToMiladi() && start.ToMiladi() >= a.StartDate);

            if (slide == null)
            {
                slide = _ads.SingleOrDefault(a => a.EndDate >= end.ToMiladi() && end.ToMiladi() >= a.StartDate);

                if (slide == null)
                {
                    message = "";
                    return false;
                }
                else
                {
                    message = $"تداخل زمانی با اسلاید ({slide.Id})، تاریخ پایان اسلاید شما باید از تاریخ \" {slide.StartDate.ToShamsi() } \" کوچکتر باشد";
                    return true;
                }

            }
            else
            {
                message = $"تداخل زمانی با اسلاید ({slide.Id})، تاریخ شروع اسلاید شما باید از تاریخ \" {slide.EndDate.ToShamsi() } \" بزرگتر باشد";
                return true;
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

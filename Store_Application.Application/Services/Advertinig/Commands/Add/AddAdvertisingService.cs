using Microsoft.AspNetCore.Http;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Extentions;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Site;
using Store_Application.Domain.Enums;
using System;
using System.IO;
using System.Linq;

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
            string message;
            if (ConflictTemporalInterference(req.StartDate,req.EndDate,req.Place,out message))
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

                    var ad = new Advertising()
                    {
                        Description = req.Description,
                        InsertTime = DateTime.Now,
                        Place = req.Place,
                        Title = req.Title.Trim(),
                        StartDate = startDate.ToMiladi(),
                        EndDate = endDate.ToMiladi(),
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

        }

        private bool ConflictTemporalInterference(DateTime start, DateTime end, AdvertisingPlaces place,out string message)
        {
            var _ads = _db.Advertisings.Where(a => a.Place.Equals(place));

            var slide = _ads.SingleOrDefault(a => a.EndDate >= start.ToMiladi() && start.ToMiladi() >= a.StartDate);

            if (slide == null)
            {
                slide = _ads.SingleOrDefault(a => a.EndDate >= end.ToMiladi() && end.ToMiladi() >= a.StartDate );

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

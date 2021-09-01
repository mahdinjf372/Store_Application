using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.BrandSlider.Commands.Delete
{
    public class DeleteSlideService : IDeleteSlideService
    {
        private readonly IDataBaseContext _db;
        public DeleteSlideService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var slide = _db.BrandSlides.Find(id);

                slide.isRemoved = true;
                slide.RemovedTime = DateTime.Now;

                _db.BrandSlides.Update(slide);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "اسلاید با موفقیت حذف شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "حذف اسلاید با شکست مواجه شد"
                };
            }
        }
    }
}

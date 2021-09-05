using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Advertinig.Commands.Delete
{
    public class DeleteAdvertisingService : IDeleteAdvertisingService
    {
        private readonly IDataBaseContext _db;
        public DeleteAdvertisingService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var ad = _db.Advertisings.Find(id);
                ad.RemovedTime = DateTime.Now;
                ad.isRemoved = true;

                _db.Advertisings.Update(ad);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "بنر با موفقیت حذف شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "حذف بنر با شکست مواجه شد"
                };
            }
        }
    }
}

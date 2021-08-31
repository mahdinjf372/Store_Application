using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Products.Commands.DeleteImage
{
    public class DeleteImageService : IDeleteImageService
    {
        private readonly IDataBaseContext _db;
        public DeleteImageService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var image = _db.ProductImages.Find(id);
                image.isRemoved = true;
                image.RemovedTime = DateTime.Now;
                _db.ProductImages.Update(image);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "تصویر با موفقیت حذف شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "حذف تصویر با شکست مواجه شد"
                };
            }

        }
    }
}

using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Product;
using System;
using System.Linq;

namespace Store_Application.Application.Services.ProductSliders.Commands.DeleteProductSlider
{
    public class DeleteProductSliderService : IDeleteProductSliderService
    {
        private readonly IDataBaseContext _db;
        public DeleteProductSliderService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestDeleteProductSliderDto req)
        {
            try
            {
                var ps = _db.ProductSliders.SingleOrDefault(ps => ps.ProductId.Equals(req.ProductId) &&
                                    ps.SliderId.Equals(req.SliderId) &&
                                    !ps.isRemoved);

                ps.isRemoved = true;
                ps.RemovedTime = DateTime.Now;

                _db.ProductSliders.Update(ps);
                _db.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "محصول با موفقیت از اسلایدر حذف شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "حذف محصول از اسلایدر با شکست مواجه شد"
                };
            }
        }
    }
}

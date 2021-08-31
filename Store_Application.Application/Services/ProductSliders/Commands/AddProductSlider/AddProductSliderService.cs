using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Product;
using System;
using System.Linq;

namespace Store_Application.Application.Services.ProductSliders.Commands.AddProductSlider
{
    public class AddProductSliderService : IAddProductSliderService
    {
        private readonly IDataBaseContext _db;
        public AddProductSliderService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddProductSliderDto req)
        {
            try
            {
                var ps = new ProductSlider();

                ps.InsertTime = DateTime.Now;
                ps.ProductId = req.ProductId;
                ps.SliderId = req.SliderId;
                _db.ProductSliders.Add(ps);
                _db.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "محصول با موفقیت به اسلایدر افزوده شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "افزودن محصول به اسلایدر با شکست مواجه شد"
                };
            }
        }
    }
}

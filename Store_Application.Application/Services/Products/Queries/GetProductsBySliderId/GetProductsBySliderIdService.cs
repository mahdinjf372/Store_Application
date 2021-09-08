using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Products.Queries.GetProductsBySliderId
{
    public class GetProductsBySliderIdService : IGetProductsBySliderIdService
    {
        private readonly IDataBaseContext _db;
        public GetProductsBySliderIdService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetProductsBySliderIdDto> Execute(Domain.Enums.ProductSliders sliderId)
        {

            var _sliderId = ((int)sliderId);

            var products = _db.ProductSliders
                .Include(s => s.Product)
                .ThenInclude(p => p.Images)
                .Include(s => s.Slider)
                .Where(s => s.SliderId.Equals(_sliderId) && s.Product.Displayed)
                .OrderBy(s => s.InsertTime)
                .Take(20)
                .Select(s => new GetProductDto
                {
                    Id = s.Product.Id,
                    ImageTitle = s.Product.Images.SingleOrDefault(i => i.IsMainImage).Name,
                    Title = s.Product.Title,
                    Price = s.Product.Price,
                    DiscountAmount = s.Product.DiscountAmount,
                }).ToList();

            var sliderTitle = _db.Sliders.Find(_sliderId).Title;

            var res = new ResultGetProductsBySliderIdDto
            {
                Products = products,
                SliderTitle = sliderTitle
            };

            return new ResultDto<ResultGetProductsBySliderIdDto>
            {
                Data = res,
                IsSuccess = true,
            };
        }
    }
}
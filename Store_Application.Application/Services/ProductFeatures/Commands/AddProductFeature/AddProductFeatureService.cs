using System;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Domain.Entities.Product;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.ProductFeatures.Commands.AddProductFeature
{
    public class AddProductFeatureService : IAddProductFeatureService
    {
        private readonly IDataBaseContext _db;
        public AddProductFeatureService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddProductFeatureDto req)
        {
            try
            {
                _db.ProductFeatures.Add(new ProductFeature
                {
                    FeatureId = req.FeatureId,
                    InsertTime = DateTime.Now,
                    isBold = req.IsBold,
                    isRemoved = false,
                    ProductId = req.ProductId,
                    Value = req.Value
                });

                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "ویژگی با موفقیت ثبت شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ثبت ویژگی با شکست مواجه شد"
                };
            }
        }
    }
}

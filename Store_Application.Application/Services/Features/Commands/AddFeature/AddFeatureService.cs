using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Product;
using System;

namespace Store_Application.Application.Services.Features.Commands.AddFeature
{
    public class AddFeatureService : IAddFeatureService
    {
        private readonly IDataBaseContext _db;
        public AddFeatureService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(string featureName)
        {
            var feature = new Feature()
            {
                InsertTime = DateTime.Now,
                isRemoved = false,
                Title = featureName
            };

            _db.Features.Add(feature);
            _db.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "ویژگی با موفقیت اضافه شد"
            };

        }
    }


}

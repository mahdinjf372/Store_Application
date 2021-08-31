using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Products.Commands.DeleteProduct
{
    public class DeleteProductService : IDeleteProductService
    {
        private readonly IDataBaseContext _db;
        public DeleteProductService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int id)
        {
            try
            {
                var product = _db.Products.Find(id);

                product.isRemoved = true;
                product.RemovedTime = DateTime.Now;

                _db.Products.Update(product);
                _db.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "محصول با موفقیت حذف شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "حذف محصول با شکست مواجه شد"
                };
            }

        }
    }
}

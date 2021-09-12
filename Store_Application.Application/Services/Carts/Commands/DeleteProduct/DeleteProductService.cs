using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Carts.Commands.DeleteProduct
{
    public class DeleteProductService : IDeleteProductService
    {
        private readonly IDataBaseContext _db;
        public DeleteProductService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<bool> Execute(int ProductId, int userId, Guid BrowserId)
        {

            var query = _db.CartItems.AsQueryable();
            if (userId > 0)
            {
                query = query.Where(p => p.Cart.UserId == userId && p.ProductId.Equals(ProductId)).AsQueryable();
            }
            else
            {
                query = query.Where(p => p.Cart.BrowserId == BrowserId && p.ProductId.Equals(ProductId)).AsQueryable();
            }

            var cartitem = query.FirstOrDefault();

            if (cartitem != null)
            {
                cartitem.isRemoved = true;
                cartitem.RemovedTime = DateTime.Now;
                _db.CartItems.Update(cartitem);
                _db.SaveChanges();
                return new ResultDto<bool>
                {
                    Data = true,
                    IsSuccess = true,
                    Message = "محصول از سبد خرید شما حذف شد"
                };
            }
            else
            {
                return new ResultDto<bool>
                {
                    Data = false,
                    IsSuccess = false,
                    Message = "محصول یافت نشد"
                };
            }
        }
    }

}

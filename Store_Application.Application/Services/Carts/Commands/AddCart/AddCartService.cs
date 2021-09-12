using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Cart;
using Store_Application.Domain.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Application.Application.Services.Carts.Commands.AddCart
{
    public class AddCartService : IAddCartService
    {
        private readonly IDataBaseContext _db;
        public AddCartService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddCartDto req)
        {
            try
            {
                var res = new ResultDto();
                var cart = new Cart()
                {
                    BrowserId = req.BrowserId,
                    InsertTime = DateTime.Now,
                    UserId = req.UserId,
                    Finished = false,
                    CartItems = new List<CartItem>()
                };

                _db.Carts.Add(cart);
                _db.SaveChanges();

                res.IsSuccess = true;
                res.Message = "سبد با موفقیت برای کارب ایجاشد";
                return res;
            }
            catch (Exception e)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "افزودن محصول به سبد با شکست مواجه شد"
                };
            }
        }
    }
}

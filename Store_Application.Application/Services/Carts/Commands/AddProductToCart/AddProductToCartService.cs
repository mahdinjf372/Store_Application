using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.Cart;
using Store_Application.Domain.Entities.Product;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Carts.Commands.AddProductToCart
{
    public class AddProductToCartService : IAddProductToCartService
    {
        private readonly IDataBaseContext _db;
        public AddProductToCartService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddProductToCartDto req)
        {
            try
            {
                var res = new ResultDto();
                Cart cart;
                if (req.UserId > 0)
                {
                    cart = _db.Carts.SingleOrDefault(c => c.UserId.Equals(req.UserId) && !c.Finished);
                }
                else
                {
                    cart = _db.Carts.SingleOrDefault(c => c.BrowserId.Equals(req.BrowserId) && !c.Finished);
                }

                var product = _db.Products.Find(req.ProductId);
                if (product == null)
                    throw new Exception();

                var cartItem = _db.CartItems.SingleOrDefault(i => i.CartId.Equals(cart.Id) && i.ProductId.Equals(req.ProductId));
                if (cartItem == null)
                {
                    res = AddCartItem(req, cart, product);
                }
                else
                {
                    res = UpdateCartItem(req, cartItem, product);
                }

                if (res.IsSuccess)
                {
                    res.Message = "محصول با موفقیت به سبد افزوده شد";
                }
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

        private ResultDto AddCartItem(RequestAddProductToCartDto req, Cart cart, Product product)
        {
            var res = new ResultDto();
            var cartItem = new CartItem()
            {
                CartId = cart.Id,
                Count = req.Count,
                InsertTime = DateTime.Now,
                Price = product.Price,
                ProductId = product.Id,
            };

            res = ValidateCount(product, cartItem);
            if (res.IsSuccess)
            {
                _db.CartItems.Add(cartItem);
                _db.SaveChanges();
                res.IsSuccess = true;
            }

            return res;
        }

        private ResultDto UpdateCartItem(RequestAddProductToCartDto req, CartItem cartItem, Product product)
        {
            var res = new ResultDto();

            if (req.FinallyCount != 0)
            {
                cartItem.Count = req.FinallyCount;
                res = ValidateCount(product, cartItem);
            }
            else
            {
                cartItem.Count += req.Count;
                res = ValidateCount(product, cartItem);
            }

            if (res.IsSuccess)
            {
                _db.CartItems.Update(cartItem);
                _db.SaveChanges();
            }

            return res;
        }

        private ResultDto ValidateCount(Product product, CartItem cartItem)
        {
            var res = new ResultDto();
            res.IsSuccess = true;
            if (product.Inventory < cartItem.Count)
            {
                res.IsSuccess = false;
                res.Message = "مقدار درخواستی بیشتر از مقدار موجودی میباشد";
            }
            else if (cartItem.Count < 1)
            {
                res.IsSuccess = false;
                res.Message = "مقدار درخواستی کمتر از میزان مجاز میباشد";
            }

            return res;

        }
    }
}

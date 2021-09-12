using Store_Application.Domain.Entities.Common;

namespace Store_Application.Domain.Entities.Cart
{
    public class CartItem : BaseEntity
    {
        public Product.Product Product { get; set; }
        public int? ProductId { get; set; }

        public int Count { get; set; }
        public decimal Price { get; set; }

        public Cart Cart { get; set; }
        public int CartId { get; set; }

    }
}

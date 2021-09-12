using Store_Application.Domain.Entities.Common;
using Store_Application.Domain.Entities.Product;

namespace Store_Application.Domain.Entities.Order

{
    public class OrderDetail:BaseEntity
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }

        public Product.Product Product { get; set; }
        public int ProductId { get; set; }

        public int Price { get; set; }
        public int Count { get; set; }
    }

}

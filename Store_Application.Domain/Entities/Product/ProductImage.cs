using Store_Application.Domain.Entities.Common;

namespace Store_Application.Domain.Entities.Product
{
    public class ProductImage : BaseEntity<int>
    {
        public string Name { get; set; }
        public bool IsMainImage { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}

using Store_Application.Domain.Entities.Common;

namespace Store_Application.Domain.Entities.Product
{
    public class Tag : BaseEntity
    {
        public string Title { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }

}

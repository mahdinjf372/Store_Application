using Store_Application.Domain.Entities.Product;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForSite
{
    public class GetProductsForSiteDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceWihtDiscount { get; set; }

        public string CategoryTitle { get; set; }

        public string GroupTitle { get; set; }

        public string SubgroupTitle { get; set; }

        public string ImageTitle { get; set; }

    }
}

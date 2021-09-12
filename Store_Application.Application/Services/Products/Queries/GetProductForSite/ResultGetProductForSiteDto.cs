using System.Collections.Generic;

namespace Store_Application.Application.Services.Products.Queries.GetProductForSite
{
    public class ResultGetProductForSiteDto
    {
        public int Id { get; set; }
        public int Inventory { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public int GroupId { get; set; }
        public string GroupTitle { get; set; }
        public int SubgroupId { get; set; }
        public string SubgroupTitle { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public BrandDto Brand { get; set; }
        public List<ImageDto> Images { get; set; }
        public List<ProductFeatureDto> ProductFeatures { get; set; }

    }
}

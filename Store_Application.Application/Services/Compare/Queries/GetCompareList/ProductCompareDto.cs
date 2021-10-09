using System.Collections.Generic;

namespace Store_Application.Application.Services.Compare.Queries.GetCompareList
{
    public class ProductCompareDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public string ImageName { get; set; }
        public int Inventory { get; set; }
        public List<ProductFeatureDto> ProductFeatures { get; set; }
    }
}
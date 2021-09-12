using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Components.Product
{
    public class ProductViewModel
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
        public BrandViewModel Brand { get; set; }
        public List<ImageViewModel> Images { get; set; }
        public List<ProductFeatureViewModel> ProductFeatures { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Compare.Index
{

    public class CompareViewModel
    {
        public ProductCompareViewModel Product { get; set; }
        public List<FeatureViewModel> Feature { get; set; }
        public List<ProductFeatureViewModel> ProductFeature { get; set; }
    }

    public class ProductCompareViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public string ImageName { get; set; }
        public int Inventory { get; set; }

        public List<ProductFeatureViewModel> ProductFeatures { get; set; }
    }

    public class FeatureViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ProductFeatureViewModel> Values { get; set; }
    }

    public class ProductFeatureViewModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsBold { get; set; }
        
        public int ProductId { get; set; }
        public ProductCompareViewModel Product { get; set; }

        public int FeatureId { get; set; }
        public FeatureViewModel Feature { get; set; }
    }
}

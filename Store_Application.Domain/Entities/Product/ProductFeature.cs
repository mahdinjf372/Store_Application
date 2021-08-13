using Store_Application.Domain.Entities.Common;

namespace Store_Application.Domain.Entities.Product
{
    public class ProductFeature : BaseEntity<int>
    {

        public string Value { get; set; }
        public bool isBold { get; set; }

        public int FeatureId { get; set; }
        public Feature Feature { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

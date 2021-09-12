namespace EndPoint.WebSite.Models.Components.Product
{
    public class ProductFeatureViewModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsBold { get; set; }

        public int FeatureId { get; set; }
        public FeatureViewModel Feature { get; set; }

        public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
    }
}

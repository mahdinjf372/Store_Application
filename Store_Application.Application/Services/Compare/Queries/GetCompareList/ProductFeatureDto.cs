namespace Store_Application.Application.Services.Compare.Queries.GetCompareList
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsBold { get; set; }

        public int ProductId { get; set; }
        public ProductCompareDto Product { get; set; }

        public int FeatureId { get; set; }
        public FeatureDto Feature { get; set; }
    }
}
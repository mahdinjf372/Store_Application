namespace Store_Application.Application.Services.ProductFeatures.Commands.AddProductFeature
{
    public class RequestAddProductFeatureDto
    {
        public int ProductId { get; set; }
        public int FeatureId { get; set; }
        public string Value { get; set; }
        public bool IsBold { get; set; }
    }
}

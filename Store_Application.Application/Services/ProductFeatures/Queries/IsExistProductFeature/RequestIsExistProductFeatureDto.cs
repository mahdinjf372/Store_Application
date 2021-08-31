namespace Store_Application.Application.Services.ProductFeatures.Queries.IsExistProductFeature
{
    public class RequestIsExistProductFeatureDto
    {
        public int FeatureId { get; set; }
        public int ProductId { get; set; }
        public string Value { get; set; }
    }
}

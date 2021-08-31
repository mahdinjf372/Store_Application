namespace Store_Application.Application.Services.ProductFeatures.Queries.GetProductFeatures
{
    public class ResultGetProductFeaturesDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsBold { get; set; }
        public string FeatureName { get; set; }
        public bool IsRemoved { get; set; }

    }
}

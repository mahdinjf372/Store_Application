namespace Store_Application.Application.Services.ProductFeatures.Commands.EditProductFeature
{
    public class RequestEditProductFeatureDto
    {
        public int PF_Id { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }
    }
}

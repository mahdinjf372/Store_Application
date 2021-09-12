namespace Store_Application.Application.Services.Products.Queries.GetProductForSite
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public bool IsBold { get; set; }

        public int FeatureId { get; set; }
        public FeatureDto Feature { get; set; }

        public int ProductId { get; set; }
        public ResultGetProductForSiteDto Product { get; set; }
    }





}

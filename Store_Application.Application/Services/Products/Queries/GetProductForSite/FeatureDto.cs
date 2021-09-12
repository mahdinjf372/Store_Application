using System.Collections.Generic;

namespace Store_Application.Application.Services.Products.Queries.GetProductForSite
{
    public class FeatureDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ProductFeatureDto> ProductFeatures { get; set; }
    }





}

using System.Collections.Generic;

namespace Store_Application.Application.Services.Compare.Queries.GetCompareList
{
    public class ResultGetCompareDto
    {
        public ProductCompareDto Product { get; set; }
        public List<FeatureDto> Feature { get; set; }
        public List<ProductFeatureDto> ProductFeature { get; set; }
    }
}
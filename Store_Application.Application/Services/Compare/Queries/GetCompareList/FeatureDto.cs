using System.Collections.Generic;

namespace Store_Application.Application.Services.Compare.Queries.GetCompareList
{
    public class FeatureDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ProductFeatureDto> Values { get; set; }
    }
}
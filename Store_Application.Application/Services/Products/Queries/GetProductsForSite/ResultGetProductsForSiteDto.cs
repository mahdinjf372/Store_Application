using System.Collections.Generic;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForSite
{
    public class ResultGetProductsForSiteDto
    {
        public IEnumerable<GetProductsForSiteDto> Products { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }

}

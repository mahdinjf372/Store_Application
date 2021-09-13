using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForSite
{
    public class RequestGetProductsForSiteDto
    {
        public string SortBy { get; set; }
        public string Searchkey { get; set; }
        public int Page { get; set; }
        public int Take { get; set; } = 10;
        public int? CategoryId { get; set; } = null;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForAdmin
{
    public class RequestGetProductsDto
    {
        public string Searchkey { get; set; }
        public int Page { get; set; }
        public int Take { get; set; } = 10;
    }
}

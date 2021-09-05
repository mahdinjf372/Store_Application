using System.Collections.Generic;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForAdmin
{
    public class ResultGetProductsForAdminDto
    {
        public IEnumerable<GetProductsForAdminDto> Products { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }

}

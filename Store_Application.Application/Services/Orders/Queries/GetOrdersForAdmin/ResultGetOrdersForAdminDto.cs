using System.Collections.Generic;

namespace Store_Application.Application.Services.Orders.Queries.GetOrdersForAdmin
{
    public class ResultGetOrdersForAdminDto
    {
        public List<OrderForAdminDto> Orders { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }
}

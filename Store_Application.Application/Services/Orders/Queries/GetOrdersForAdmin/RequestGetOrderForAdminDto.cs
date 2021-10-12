using System;

namespace Store_Application.Application.Services.Orders.Queries.GetOrdersForAdmin
{
    public class RequestGetOrderForAdminDto
    {
        public int Page { get; set; } = 1;
        public int Take { get; set; } = 10;
        public int? UserId { get; set; }
        public int? OrderId { get; set; }
        public OrderStatesDto? State { get; set; }
        public DateTime? FromDateOrder { get; set; }
        public DateTime? ToDateOrder { get; set; }
        public DateTime? FromDatePay { get; set; }
        public DateTime? ToDatePay { get; set; }
    }

}



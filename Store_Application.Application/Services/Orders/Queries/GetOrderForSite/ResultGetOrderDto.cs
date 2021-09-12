using System.Collections.Generic;

namespace Store_Application.Application.Services.Orders.Queries.GetOrderForSite
{
    public class ResultGetOrderDto
    {
        public int Id { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public decimal TotalAmount { get; set; }

        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}

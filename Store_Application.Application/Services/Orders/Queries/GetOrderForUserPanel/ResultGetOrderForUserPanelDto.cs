using System.Collections.Generic;

namespace Store_Application.Application.Services.Orders.Queries.GetOrderForUserPanel
{
    public class ResultGetOrderForUserPanelDto
    {
        public int Id { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public decimal totalAmount { get; set; }


        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}

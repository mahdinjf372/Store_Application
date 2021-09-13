using Store_Application.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Store_Application.Application.Services.Orders.Queries.GetOrdersForUserPanel
{
    public class ResultGetOrderForUserPanel
    {
        public int Id { get; set; }
        public bool Finished { get; set; }
        public OrderState State { get; set; }
        public DateTime? FinallyDate { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal totalAmount { get; set; }
        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}

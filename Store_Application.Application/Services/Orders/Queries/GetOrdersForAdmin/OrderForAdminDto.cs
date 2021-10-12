using System;

namespace Store_Application.Application.Services.Orders.Queries.GetOrdersForAdmin
{
    public class OrderForAdminDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderInsertTime { get; set; }
        public OrderStatesDto State { get; set; }
        public int PayId { get; set; }
        public decimal PayAmount { get; set; }
        public bool isPay { get; set; }
        public DateTime? PayDate { get; set; }
        public string Authority { get; set; }
        public long RefId { get; set; }
    }

}



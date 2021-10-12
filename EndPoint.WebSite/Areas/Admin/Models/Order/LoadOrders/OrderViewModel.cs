using EndPoint.WebSite.Areas.Admin.Models.Order.Common;
using System;

namespace EndPoint.WebSite.Areas.Admin.Models.Order.LoadOrders
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderInsertTime { get; set; }
        public OrderStatesViewModel State { get; set; }
        public int PayId { get; set; }
        public decimal PayAmount { get; set; }
        public bool isPay { get; set; }
        public DateTime? PayDate { get; set; }
        public string Authority { get; set; }
        public long RefId { get; set; }
    }
}

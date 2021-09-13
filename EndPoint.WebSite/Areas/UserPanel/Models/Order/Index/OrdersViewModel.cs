using Store_Application.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.UserPanel.Models.Order.Index
{
    public class OrdersViewModel
    {
        public int Id { get; set; }
        public bool Finished { get; set; }
        public OrderState State { get; set; }
        public DateTime? FinallyDate { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal totalAmount { get; set; }
        public List<OrderDetailViewModel> OrderDetails { get; set; }

    }
}

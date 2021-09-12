using Store_Application.Domain.Entities.Common;
using System;
using System.Collections.Generic;

namespace Store_Application.Domain.Entities.Finance
{
    public class RequestPay : BaseEntity
    {
        public Guid Guid { get; set; }
        public User.User User { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPay { get; set; }
        public DateTime? PayDate { get; set; }
        public string Authority { get; set; }
        public long RefId { get; set; } = 0;
        public ICollection<Order.Order> Orders { get; set; }


    }
}

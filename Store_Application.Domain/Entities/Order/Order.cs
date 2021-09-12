using Store_Application.Domain.Entities.Common;
using Store_Application.Domain.Entities.Finance;
using Store_Application.Domain.Entities.User;
using Store_Application.Domain.Enums;
using System.Collections.Generic;

namespace Store_Application.Domain.Entities.Order
{
    public class Order : BaseEntity
    {
        public User.User User { get; set; }
        public int UserId { get; set; }

        public RequestPay RequestPay { get; set; }
        public int RequestPayId { get; set; }

        public OrderState OrderState { get; set; }

        public string Address { get; set; }

        public string ReceiverName { get; set; }

        public string ReceiverPhone { get; set; }

        public string PostCode { get; set; }

        public string Description { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        
    }

}

using Store_Application.Domain.Entities.Common;
using Store_Application.Domain.Entities.User;
using System;
using System.Collections.Generic;

namespace Store_Application.Domain.Entities.Cart
{
    public class Cart : BaseEntity
    {
        public User.User User { get; set; }
        public int? UserId { get; set; }

        public Guid BrowserId { get; set; }
        public bool Finished { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}

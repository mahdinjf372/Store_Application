using Store_Application.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Domain.Entities.Favorite
{
    public class Favorite : BaseEntity
    {
        public int ProductId { get; set; }
        public Product.Product Product { get; set; }

        public int? UserId { get; set; }
        public User.User User { get; set; }

        public Guid BrowserId { get; set; }
    }
}

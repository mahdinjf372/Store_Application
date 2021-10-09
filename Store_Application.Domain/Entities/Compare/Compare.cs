using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Domain.Entities.Common;

namespace Store_Application.Domain.Entities.Compare
{
    public class Compare: BaseEntity<int>
    {
        public Guid BrowserId { get; set; }
        public int? UserId { get; set; }
        public User.User User { get; set; }
        public int ProductId { get; set; }
        public Product.Product Product { get; set; }
    }
}

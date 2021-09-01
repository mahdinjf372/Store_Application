using Store_Application.Domain.Entities.Common;
using System.Collections.Generic;

namespace Store_Application.Domain.Entities.Product
{
    public class Brand : BaseEntity<int>
    {
        public string Title { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}

using Store_Application.Domain.Entities.Common;
using System.Collections.Generic;

namespace Store_Application.Domain.Entities.Product
{
    public class Feature : BaseEntity<int>
    {
        public string Title { get; set; }
        public ICollection<ProductFeature> Values { get; set; }
    }
}

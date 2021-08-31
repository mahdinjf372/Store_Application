using Store_Application.Domain.Entities.Common;
using Store_Application.Domain.Entities.Product;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Domain.Entities.Product
{
    public class Slider : BaseEntity<int>
    {
        public string Title { get; set; }

        public ICollection<ProductSlider> ProductSliders { get; set; }
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Models.Search.Index
{
    public class SearchProductViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceWihtDiscount { get; set; }

        public string CategoryTitle { get; set; }

        public string GroupTitle { get; set; }

        public string SubgroupTitle { get; set; }

        public string ImageTitle { get; set; }
    }
}

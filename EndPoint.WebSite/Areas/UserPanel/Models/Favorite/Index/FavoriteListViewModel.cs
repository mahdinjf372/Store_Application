using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.UserPanel.Models.Favorite.Index
{
    public class FavoriteListViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public byte Rate { get; set; }
    }
}

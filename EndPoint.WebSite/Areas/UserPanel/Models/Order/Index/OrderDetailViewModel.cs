namespace EndPoint.WebSite.Areas.UserPanel.Models.Order.Index
{
    public class OrderDetailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Price { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public int Count { get; set; }
    }
}

namespace Store_Application.Application.Services.Orders.Queries.GetOrderForPay
{
    public class OrderDetailForPayDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal SumPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
    }
}

namespace Store_Application.Application.Services.Carts.Queries.GetCartForSite
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal DiscountAmount { get; set; }
        public string ImageName { get; set; }
        public int Count { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
    }

}

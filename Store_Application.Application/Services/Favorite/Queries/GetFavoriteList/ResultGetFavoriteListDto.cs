namespace Store_Application.Application.Services.Favorite.Queries.GetFavoriteList
{
    public class ResultGetFavoriteListDto
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
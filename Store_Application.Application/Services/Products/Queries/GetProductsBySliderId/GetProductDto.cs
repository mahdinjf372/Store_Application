namespace Store_Application.Application.Services.Products.Queries.GetProductsBySliderId
{
    public class GetProductDto
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string ImageTitle { get; set; }

        public decimal DiscountAmount { get; set; }

    }
}

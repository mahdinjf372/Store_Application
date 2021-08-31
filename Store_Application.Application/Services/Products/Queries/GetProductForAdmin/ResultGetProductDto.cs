using System.Collections.Generic;

namespace Store_Application.Application.Services.Products.Queries.GetProductForAdmin
{
    public class ResultGetProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Decription { get; set; }
        public int CategoryId { get; set; }
        public int GroupId { get; set; }
        public int SubgroupId { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountAmount { get; set; }
        public int Inventory { get; set; }
        public int BrandId { get; set; }
        public bool Displayed { get; set; }

        public List<ProductImage> Images { get; set; }

    }





}

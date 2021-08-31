using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Store_Application.Domain.Entities.Product;

namespace Store_Application.Application.Services.Products.Commands.AddProduct
{
    public class RequestAddProductDto
    {
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal DiscountAmount { get; set; }

        public int Inventory { get; set; }

        public bool Displayed { get; set; }

        public int CategoryId { get; set; }
        public int GroupId { get; set; }
        public int SubGroupId { get; set; }

        public int BrandId { get; set; }

        public ICollection<ProductFeature> Features { get; set; }

        public IFormFile MainImage { get; set; }

        public List<IFormFile> GalleryImages { get; set; }

    }
}

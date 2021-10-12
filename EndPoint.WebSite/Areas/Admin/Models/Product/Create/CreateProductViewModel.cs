using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Product.Create
{
    public class CreateProductViewModel
    {
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string Tags { get; set; }

        public decimal Price { get; set; }

        public decimal DiscountAmount { get; set; }

        public int Inventory { get; set; }

        public bool Displayed { get; set; }

        public int CategoryId { get; set; }
        public int GroupId { get; set; }
        public int SubGroupId { get; set; }

        public int BrandId { get; set; }

        public IFormFile MainImage { get; set; }

        public List<IFormFile> GalleryImages { get; set; }


    }
}

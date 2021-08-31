﻿using Store_Application.Domain.Entities.Product;

namespace Store_Application.Application.Services.Products.Queries.GetProductsForAdmin
{
    public class GetProductsDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int Inventory { get; set; }

        public bool Displayed { get; set; }

        public string CategoryTitle { get; set; }

        public string GroupTitle { get; set; }

        public string SubgroupTitle { get; set; }

        public string ImageTitle { get; set; }

        public bool IsRemoved { get; set; }

    }
}

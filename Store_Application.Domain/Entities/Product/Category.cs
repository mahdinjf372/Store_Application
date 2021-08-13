using Store_Application.Domain.Entities.Common;
using System.Collections.Generic;

namespace Store_Application.Domain.Entities.Product
{
    public class Category : BaseEntity
    {
        public string Title { get; set; }
        public string ImageName { get; set; }

        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }


        public ICollection<Category> SubCategories { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

using System.Collections.Generic;

namespace Store_Application.Application.Services.Categories.Queries.GetCategoriesForAdmin
{
    public class ResultGetCategoriesForAdminDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public bool isRemoved { get; set; }

        public int? ParentCategoryId { get; set; }
        public Domain.Entities.Product.Category ParentCategory { get; set; }

        public ICollection<Domain.Entities.Product.Category> SubCategories { get; set; }

    }
}

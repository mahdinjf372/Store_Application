using System.Collections.Generic;

namespace Store_Application.Application.Services.Categories.Queries.GetCategories
{
    public class ResultGetCategoriesDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }

        public int? ParentCategoryId { get; set; }
        public ResultGetCategoriesDto ParentCategory { get; set; }

        public ICollection<ResultGetCategoriesDto> SubCategories { get; set; }

    }
}

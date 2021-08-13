namespace Store_Application.Application.Services.Categories.Commands.AddCategory
{
    public class RequestAddCategoryDto
    {
        public string Title { get; set; }
        public string ImageName { get; set; }

        public int? ParentCategoryId { get; set; }
    }
}

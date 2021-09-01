using Microsoft.AspNetCore.Http;

namespace Store_Application.Application.Services.BrandSlider.Commands.Add
{
    public class RequestAddSlideDto
    {
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string LinkTo { get; set; }
        public IFormFile Image { get; set; }
    }
}

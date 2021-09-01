using Microsoft.AspNetCore.Http;

namespace Store_Application.Application.Services.MainSlider.Commands.Edit
{
    public class RequestEditSlideDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string LinkTo { get; set; }
        public IFormFile Image { get; set; }
    }
}

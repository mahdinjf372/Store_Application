using Store_Application.Domain.Entities.Common;

namespace Store_Application.Domain.Entities.Site
{
    public class BrandSlider : BaseEntity
    {
        public string Title { get; set; }

        public string ImageName { get; set; }

        public string LinkTo { get; set; }

    }
}

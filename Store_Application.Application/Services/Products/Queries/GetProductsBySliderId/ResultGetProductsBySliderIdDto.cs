using System.Collections.Generic;

namespace Store_Application.Application.Services.Products.Queries.GetProductsBySliderId
{
    public class ResultGetProductsBySliderIdDto
    {
        public List<GetProductDto> Products { get; set; }

        public string SliderTitle { get; set; }

    }
}

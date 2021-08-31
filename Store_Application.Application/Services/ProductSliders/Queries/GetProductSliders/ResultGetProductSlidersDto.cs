using System;

namespace Store_Application.Application.Services.ProductSliders.Queries.GetProductSliders
{
    public class ResultGetProductSlidersDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SliderId { get; set; }
    }
}

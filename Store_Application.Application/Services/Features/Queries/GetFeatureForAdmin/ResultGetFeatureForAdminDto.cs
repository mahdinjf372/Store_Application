using Store_Application.Domain.Entities.Product;
using System.Collections.Generic;

namespace Store_Application.Application.Services.Features.Queries.GetFeatureForAdmin
{
    public class ResultGetFeatureForAdminDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<ProductFeature> Values { get; set; }
    }
}

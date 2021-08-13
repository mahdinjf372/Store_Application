using FluentValidation;
using Store_Application.Domain.Entities.Product;

namespace Store_Application.Infrastruture.FluentValidation.EntityValidators
{
    public class ProductFeatureValidator : AbstractValidator<ProductFeature>
    {
        public ProductFeatureValidator()
        {

        }
    }
}

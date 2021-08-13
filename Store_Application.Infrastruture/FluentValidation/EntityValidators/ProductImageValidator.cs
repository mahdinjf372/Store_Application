using FluentValidation;
using Store_Application.Domain.Entities.Product;

namespace Store_Application.Infrastruture.FluentValidation.EntityValidators
{
    public class ProductImageValidator : AbstractValidator<ProductImage>
    {
        public ProductImageValidator()
        {
            RuleFor(p => p.Name)
                .NotNull().WithMessage("تصویر اجباریست")
                .NotEmpty().WithMessage("تصویر اجباریست");
        }
    }
}

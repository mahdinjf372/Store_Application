using FluentValidation;
using Store_Application.Domain.Entities.Product;

namespace Store_Application.Infrastruture.FluentValidation.EntityValidators
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(p => p.Title)
                .NotNull().WithMessage("نام برند اجباریست")
                .NotEmpty().WithMessage("نام برند اجباریست")
                .MaximumLength(50).WithMessage("نام برند نمی تواند بیشتر از 50 کاراکتر باشد");

            RuleFor(p => p.ImageName)
                .NotNull().WithMessage("تصویر اجباریست")
                .NotEmpty().WithMessage("تصویر اجباریست");
        }
    }
}

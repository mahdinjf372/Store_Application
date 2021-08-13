using FluentValidation;
using Store_Application.Domain.Entities.Product;

namespace Store_Application.Infrastruture.FluentValidation.EntityValidators
{
    public class FeatureValidator : AbstractValidator<Feature>
    {
        public FeatureValidator()
        {
            RuleFor(p => p.Title)
                .NotNull().WithMessage("نام ویژگی اجباریست")
                .NotEmpty().WithMessage("نام ویژگی اجباریست")
                .MaximumLength(200).WithMessage("نام ویژگی نمی تواند بیشتر از 200 کاراکتر باشد");

        }
    }
}

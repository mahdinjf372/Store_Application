using FluentValidation;
using Store_Application.Domain.Entities.Product;

namespace Store_Application.Infrastruture.FluentValidation.EntityValidators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.Title)
                .NotNull().WithMessage("نام دسته بندی اجباریست")
                .NotEmpty().WithMessage("نام دسته بندی اجباریست")
                .MaximumLength(30).WithMessage("نام دسته بندی نمی تواند بیشتر از 200 کاراکتر باشد");

        }
    }
}

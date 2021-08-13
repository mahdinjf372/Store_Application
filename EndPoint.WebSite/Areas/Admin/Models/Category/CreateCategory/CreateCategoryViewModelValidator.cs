using FluentValidation;

namespace EndPoint.WebSite.Areas.Admin.Models.Category.CreateCategory
{
    public class CreateCategoryViewModelValidator : AbstractValidator<CreateCategoryViewModel>
    {
        public CreateCategoryViewModelValidator()
        {

            RuleFor(x => x.Title)
                .NotNull().WithMessage("نام کاربری اجباریست")
                .NotEmpty().WithMessage("نام کاربری اجباریست")
                .MaximumLength(25).WithMessage("نمیوتند بیشتر از ۲۵ کاراکتر باشد");
        }
    }
}

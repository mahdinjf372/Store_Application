using FluentValidation;

namespace EndPoint.WebSite.Areas.Admin.Models.Category.EditCategory
{
    public class EditCategoryViewModelValidator : AbstractValidator<EditCategoryViewModel>
    {
        public EditCategoryViewModelValidator()
        {
            RuleFor(x => x.Id).NotNull();

            RuleFor(x => x.Title)
                .NotNull().WithMessage("نام کاربری اجباریست")
                .NotEmpty().WithMessage("نام کاربری اجباریست")
                .MaximumLength(25).WithMessage("نمیوتند بیشتر از ۲۵ کاراکتر باشد");
        }
    }
}

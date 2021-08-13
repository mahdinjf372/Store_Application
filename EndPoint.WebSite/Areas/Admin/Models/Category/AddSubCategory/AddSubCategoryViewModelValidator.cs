using FluentValidation;

namespace EndPoint.WebSite.Areas.Admin.Models.Category.AddSubCategory
{
    public class AddSubCategoryViewModelValidator : AbstractValidator<AddSubCategoryViewModel>
    {
        public AddSubCategoryViewModelValidator()
        {
            RuleFor(x => x.ParentCategoryId).NotNull().WithMessage("کد سر گروه صحیح نیست");

            RuleFor(x => x.Title)
                .NotNull().WithMessage("نام زیرگروه اجباریست")
                .NotEmpty().WithMessage("نام زیرگروه اجباریست")
                .MaximumLength(25).WithMessage("نمیوتند بیشتر از ۲۵ کاراکتر باشد");
        }
    }
}

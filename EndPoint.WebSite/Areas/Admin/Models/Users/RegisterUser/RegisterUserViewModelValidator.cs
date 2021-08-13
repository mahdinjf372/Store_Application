using FluentValidation;
using FluentValidation.Validators;

namespace EndPoint.WebSite.Areas.Admin.Models.Users.RegisterUser
{
    public class RegisterUserViewModelValidator : AbstractValidator<RegisterUserViewModel>
    {
        public RegisterUserViewModelValidator()
        {
            RuleFor(x => x.Username)
                .NotNull().WithMessage("نام کاربری اجباریست")
                .NotEmpty().WithMessage("نام کاربری اجباریست")
                .Matches(@"^[A-Za-z][A-Za-z0-9]*$").WithMessage("فقط حروف و اعداد انگلیسی");

            RuleFor(x => x.Email)
                .EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("فرمت ایمل نادرست")
                .NotNull().WithMessage("ایمیل اجباریست")
                .NotEmpty()
                .WithMessage("ایمیل اجباریست");

            RuleFor(x => x.RoleId)
                .NotNull().WithMessage("انتخاب نقش اجباریست")
                .NotEqual(0).WithMessage("انتخاب نقش اجباریست");


            RuleFor(x => x.Password)
                .NotNull().WithMessage("کلمه عبور اجباریست")
                .NotEmpty().WithMessage("کلمه عبور اجباریست")
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر");

            RuleFor(x => x.RePassword)
                .Equal(x => x.Password).WithMessage("تکرار کلمه عبور با کلمه عبور مطابقت ندارد");
        }
    }
}

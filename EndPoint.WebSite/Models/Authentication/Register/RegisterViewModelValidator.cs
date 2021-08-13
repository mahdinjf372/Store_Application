using FluentValidation;
using FluentValidation.Validators;

namespace EndPoint.WebSite.Models.Authentication.Register
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
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

            RuleFor(x => x.Password)
                .NotNull().WithMessage("کلمه عبور اجباریست")
                .NotEmpty().WithMessage("کلمه عبور اجباریست")
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر");

            RuleFor(x => x.RePassword)
                .Equal(x => x.Password).WithMessage("تکرار کلمه عبور با کلمه عبور مطابقت ندارد");

            RuleFor(x => x.AgreeToTermsAndConditions)
                .NotEqual(false).WithMessage("برای ثبت نام باید با قوانین و مقررات موافقت کنید");
        }
    }
}

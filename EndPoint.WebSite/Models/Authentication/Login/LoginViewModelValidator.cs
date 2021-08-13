using FluentValidation;
using FluentValidation.Validators;

namespace EndPoint.WebSite.Models.Authentication.Login
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("فرمت ایمل نادرست")
                .NotNull().WithMessage("ایمیل اجباریست")
                .NotEmpty().WithMessage("ایمیل اجباریست");

            RuleFor(x => x.Password)
                .NotNull().WithMessage("کلمه عبور اجباریست")
                .NotEmpty().WithMessage("کلمه عبور اجباریست")
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر");

        }
    }
}

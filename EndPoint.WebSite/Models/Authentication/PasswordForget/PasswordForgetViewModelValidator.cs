using FluentValidation;
using FluentValidation.Validators;

namespace EndPoint.WebSite.Models.Authentication.PasswordForget
{
    public class PasswordForgetViewModelValidator : AbstractValidator<PasswordForgetViewModel>
    {
        public PasswordForgetViewModelValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("فرمت ایمل نادرست")
                .NotNull().WithMessage("ایمیل اجباریست")
                .NotEmpty().WithMessage("ایمیل اجباریست");
        }
    }
}

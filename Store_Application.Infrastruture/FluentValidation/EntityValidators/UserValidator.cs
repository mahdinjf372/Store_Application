using FluentValidation;
using FluentValidation.Validators;
using Store_Application.Domain.Entities.User;

namespace Store_Application.Infrastruture.FluentValidation.EntityValidators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {

            RuleFor(u => u.Username)
                .MaximumLength(200).WithMessage("نام کاربری نمی تواند بیشتر از 200 کاراکتر باشد")
                .NotNull().WithMessage("نام کاربری اجباریست")
                .NotEmpty().WithMessage("نام کاربری اجباریست")
                .Matches(@"^[A-Za-z][A-Za-z0-9]*$").WithMessage("فقط حروف و اعداد انگلیسی");

            RuleFor(u => u.Phone)
                .Matches(@"(\+98|0098|0)?9\d{9}").WithMessage("لطفا شماره تلفن خود را به صورت صحیح وارد نمایید");

            RuleFor(u => u.Email)
                .EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("فرمت ایمل نادرست")
                .NotNull().WithMessage("ایمیل اجباریست")
                .NotEmpty().WithMessage("ایمیل اجباریست")
                .WithMessage("ایمیل اجباریست");

            RuleFor(u => u.Password)
                .NotNull().WithMessage("کلمه عبور اجباریست")
                .NotEmpty().WithMessage("کلمه عبور اجباریست")
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر");

            RuleFor(u => u.ActiveCode)
                .NotNull().WithMessage("کدفعالسازی اجباریست")
                .NotEmpty().WithMessage("کدفعالسازی اجباریست");

        }
    }
}

using FluentValidation;

namespace EndPoint.WebSite.Models.Authentication.PasswordRecovery
{
    public class RecoveryPasswordViewModelValidator : AbstractValidator<RecoveryPasswordViewModel>
    {
        public RecoveryPasswordViewModelValidator()
        {
            RuleFor(x => x.Password)
                .NotNull().WithMessage("کلمه عبور اجباریست")
                .NotEmpty().WithMessage("کلمه عبور اجباریست")
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر");

            RuleFor(x => x.RePassword)
                .Equal(x => x.Password).WithMessage("تکرار کلمه عبور با کلمه عبور مطابقت ندارد");
        
        }
    }
}

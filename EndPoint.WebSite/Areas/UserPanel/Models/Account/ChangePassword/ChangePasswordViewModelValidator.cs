using FluentValidation;

namespace EndPoint.WebSite.Areas.UserPanel.Models.Account.ChangePassword
{
    public class ChangePasswordViewModelValidator : AbstractValidator<ChangePasswordViewModel>
    {
        public ChangePasswordViewModelValidator()
        {
            RuleFor(x => x.OldPassword)
                .NotEmpty().WithMessage("حداقل ۸ کرکتر")
                .NotNull().WithMessage("حداقل ۸ کرکتر")
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("حداقل ۸ کرکتر")
                .NotNull().WithMessage("حداقل ۸ کرکتر")
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر");

            RuleFor(x => x.RePassword)
                .NotEmpty().WithMessage("حداقل ۸ کرکتر")
                .NotNull().WithMessage("حداقل ۸ کرکتر")
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر")
                .Equal(x => x.Password).WithMessage("تکرار کلمه عبور با کلمه عبور مطابقت ندارد");

        }
    }
}

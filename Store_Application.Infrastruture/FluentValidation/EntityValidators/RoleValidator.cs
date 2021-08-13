using Store_Application.Domain.Entities.User;
using FluentValidation;

namespace Store_Application.Infrastruture.FluentValidation.EntityValidators
{
    public class RoleValidator : AbstractValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(u => u.Name)
                .MaximumLength(200).WithMessage("نام کاربری نمی تواند بیشتر از 200 کاراکتر باشد")
                .NotNull().WithMessage("نام کاربری اجباریست")
                .NotEmpty().WithMessage("نام کاربری اجباریست")
                .Matches(@"^[A-Za-z][A-Za-z0-9]*$").WithMessage("فقط حروف و اعداد انگلیسی");
        }
    }
}

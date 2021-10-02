using FluentValidation;
using FluentValidation.Validators;
using Store_Application.Application.Interfaces.FacadPattern;
using System.Collections.Generic;

namespace EndPoint.WebSite.Areas.Admin.Models.Users.RegisterUser
{
    public class RegisterUserViewModelValidator : AbstractValidator<RegisterUserViewModel>
    {
        private readonly IUserFacad _userFacad;

        public RegisterUserViewModelValidator(IUserFacad userFacad)
        {
            _userFacad = userFacad;

            RuleFor(x => x.Username)
                .NotNull().WithMessage("نام کاربری اجباریست")
                .NotEmpty().WithMessage("نام کاربری اجباریست")
                .Matches(@"^[A-Za-z][A-Za-z0-9]*$").WithMessage("فقط حروف و اعداد انگلیسی");

            RuleFor(x => x.Email)
                .EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("فرمت ایمل نادرست")
                .NotNull().WithMessage("ایمیل اجباریست")
                .NotEmpty()
                .WithMessage("ایمیل اجباریست");

            RuleFor(x => x.Roles)
                .NotNull().WithMessage("انتخاب نقش اجباریست")
                .Must(RolesValidator).WithMessage("لطفا يكي از نقش هاي زير را براي كاربر انتخاب نماييد");

            RuleFor(x => x.Password)
                .NotNull().WithMessage("کلمه عبور اجباریست")
                .NotEmpty().WithMessage("کلمه عبور اجباریست")
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر");

            RuleFor(x => x.RePassword)
                .Equal(x => x.Password).WithMessage("تکرار کلمه عبور با کلمه عبور مطابقت ندارد");
        }

        private bool RolesValidator(List<int> roles)
        {
            bool isExist = true;
            foreach (var role in roles)
            {
                isExist = _userFacad.isExistRoleForAdminService.Execute(role).Data;
                if (!isExist)
                    break;
            }

            return isExist;
        }
    }
}

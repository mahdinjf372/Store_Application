using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Users.EditUser
{
    public class EditUserViewModelValidator : AbstractValidator<EditUserViewModel>
    {
        public EditUserViewModelValidator()
        {
            RuleFor(x => x.Id)
                .NotNull();

            RuleFor(x => x.Username)
                .NotNull().WithMessage("نام کاربری اجباریست")
                .NotEmpty().WithMessage("نام کاربری اجباریست")
                .Matches(@"^[A-Za-z][A-Za-z0-9]*$").WithMessage("فقط حروف و اعداد انگلیسی");

            RuleFor(x => x.RoleId)
                .NotNull().WithMessage("انتخاب نقش اجباریست")
                .NotEqual(0).WithMessage("انتخاب نقش اجباریست");

            RuleFor(x => x.Password)
                .MinimumLength(8).WithMessage("حداقل ۸ کرکتر");

            RuleFor(x => x.RePassword)
                .Equal(x => x.Password).WithMessage("تکرار کلمه عبور با کلمه عبور مطابقت ندارد");

            RuleFor(x => x.FullName)
                .MaximumLength(200).WithMessage("نمیتواند بیشتر از 200 کارکتر باشد");

            RuleFor(x => x.Phone)
                .Matches(@"(\+98|0098|0)?9\d{9}").WithMessage("لطفا شماره تلفن خود را به صورت صحیح وارد نمائید");

            RuleFor(x => x.age)
                .InclusiveBetween((byte)0, (byte)120).WithMessage("افراد کوچکتر از ۸ سال و بزرگتر از ۱۲۰ سال نمیتوانند ثبت نام کنند");
        }
    }
}

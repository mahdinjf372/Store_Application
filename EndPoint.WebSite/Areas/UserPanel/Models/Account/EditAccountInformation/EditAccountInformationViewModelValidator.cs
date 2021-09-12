using FluentValidation;

namespace EndPoint.WebSite.Areas.UserPanel.Models.Account.EditAccountInformation
{
    public class EditAccountInformationViewModelValidator : AbstractValidator<EditAccountInformationViewModel>
    {
        public EditAccountInformationViewModelValidator()
        {

            RuleFor(x => x.FullName)
                .MaximumLength(50).WithMessage("نمیتواند بیشتر از 50 کارکتر باشد");

            RuleFor(x => x.Phone)
                .Matches(@"(\+98|0098|0)?9\d{9}").WithMessage("لطفا شماره تلفن خود را به صورت صحیح وارد نمائید");

            RuleFor(x => x.Age)
                .InclusiveBetween((byte)0, (byte)120).WithMessage("افراد کوچکتر از ۸ سال و بزرگتر از ۱۲۰ سال نمیتوانند ثبت نام کنند");
        }
    }
}

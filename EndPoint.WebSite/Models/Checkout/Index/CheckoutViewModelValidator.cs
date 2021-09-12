using FluentValidation;

namespace EndPoint.WebSite.Models.Checkout.Index
{
    public class CheckoutViewModelValidator : AbstractValidator<CheckoutViewModel>
    {
        public CheckoutViewModelValidator()
        {
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("آدرس اجباری میباشد")
                .NotNull().WithMessage("آدرس اجباری میباشد");

            RuleFor(x => x.ReceiverName)
                .NotEmpty().WithMessage("نام اجباری میباشد")
                .NotNull().WithMessage("نام اجباری میباشد")
                .MaximumLength(50).WithMessage("نام اجباری بیشتر از 50 کارکتر باشد");

            RuleFor(x => x.ReceiverPhone)
                .NotEmpty().WithMessage("آدرس اجباری میباشد")
                .NotNull().WithMessage("آدرس اجباری میباشد")
                .Matches(@"(\+98|0098|0)?9\d{9}").WithMessage("لطفا شماره تلفن خود را به صورت صحیح وارد نمائید");

            RuleFor(x => x.agreeToTermsAndConditions)
                .Equal(true).WithMessage("برای ثبت نهایی سفارش باید با قوانین و مقررات هگز مارکت موافقت کنید");

            RuleFor(x => x.PostCode)
                .NotEmpty().WithMessage("آدرس اجباری میباشد")
                .NotNull().WithMessage("آدرس اجباری میباشد")
                .Matches(@"\b(?!(\d)\1{3})[13-9]{4}[1346-9][013-9]{5}\b").WithMessage("لطفا کدپستی خود را به صورت صحیح وارد نمائید");

        }
    }

}

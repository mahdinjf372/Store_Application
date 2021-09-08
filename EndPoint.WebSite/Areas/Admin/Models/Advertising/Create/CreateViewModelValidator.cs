using FluentValidation;
using Store_Application.Domain.Enums;
using System;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Models.Advertising.Create
{
    public class CreateViewModelValidator : AbstractValidator<CreateViewModel>
    {
        public CreateViewModelValidator()
        {
            RuleFor(x => x.Title)
                .NotNull().WithMessage("نام بنر اجباریست")
                .NotEmpty().WithMessage("نام بنر اجباریست");

            RuleFor(x => x.Description)
                .NotNull().WithMessage("توضیح برای بنر اجباریست")
                .NotEmpty().WithMessage("توضیح برای بنر اجباریست");

            RuleFor(x => x.Place)
                .Must(PlaceValidator).WithMessage("لطفا مکان بنر را انتخاب نمایید");

            RuleFor(x => x.Image)
                .NotNull().WithMessage("تصویر برای بنر اجباریست");

        }

        private bool PlaceValidator(AdvertisingPlaces Place) 
        {
            var res = Enum.GetNames(typeof(AdvertisingPlaces)).Any(p => p.Equals(Place.ToString()));

            return res;
        }
    }

}

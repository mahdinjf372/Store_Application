using FluentValidation;
using Store_Application.Domain.Enums;
using System;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Models.Advertising.Edit
{
    public class EditViewModelValidator : AbstractValidator<EditViewModel>
    {
        public EditViewModelValidator()
        {
            RuleFor(x => x.Title)
                .NotNull().WithMessage("نام بنر اجباریست")
                .NotEmpty().WithMessage("نام بنر اجباریست");

            RuleFor(x => x.Description)
                .NotNull().WithMessage("نام بنر اجباریست")
                .NotEmpty().WithMessage("نام بنر اجباریست");

            RuleFor(x => x.ImageName)
                .NotNull().WithMessage("لطفا صفحه را رفرش کنید")
                .NotEmpty().WithMessage("لطفا صفحه را رفرش کنید");

            RuleFor(x => x.Place)
                .Must(PlaceValidator).WithMessage("لطفا مکان بنر را انتخاب نمایید");

        }

        private bool PlaceValidator(AdvertisingPlaces Place)
        {
            var res = Enum.GetNames(typeof(AdvertisingPlaces)).Any(p => p.Equals(Place.ToString()));

            return res;
        }
    }
}

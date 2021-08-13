using FluentValidation;
using Store_Application.Domain.Entities.Product;

namespace Store_Application.Infrastruture.FluentValidation.EntityValidators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Title)
                .NotNull().WithMessage("نام محصول اجباریست")
                .NotEmpty().WithMessage("نام محصول اجباریست")
                .MaximumLength(200).WithMessage("نام محصول نمی تواند بیشتر از 200 کاراکتر باشد");

            RuleFor(p => p.Price)
                .GreaterThanOrEqualTo(0).WithMessage("قیمت نمیتواند کمتر از ۰ تومان باشد");

            RuleFor(p => p.DiscountAmount)
                .GreaterThanOrEqualTo(0).WithMessage("تخفیف نمیتواند کمتر از ۰ تومان باشد");

            RuleFor(p => p.Inventory)
                .GreaterThanOrEqualTo(0).WithMessage("موجودی نمیتواند کمتر از ۰ تومان باشد");

            RuleFor(p => p.CategoryId)
                .GreaterThanOrEqualTo(0).WithMessage("لطفا دسته بندی را صحیح انتخاب نمایید");

            RuleFor(p => p.CategoryId)
                .GreaterThanOrEqualTo(0).WithMessage("لطفا برند را صحیح انتخاب نمایید");
        }
    }
}

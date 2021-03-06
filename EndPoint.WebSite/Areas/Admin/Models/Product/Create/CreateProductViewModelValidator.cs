using FluentValidation;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Models.Product.Create
{
    public class CreateProductViewModelValidator : AbstractValidator<CreateProductViewModel>
    {
        private readonly IProductFacad _productFacad;
        private readonly ICategoryFacad _categoryFacad;
        private readonly IBrandFacad _brandFacad;

        private int catId = 0;
        private int grpId = 0;

        public CreateProductViewModelValidator(IProductFacad productFacad, ICategoryFacad categoryFacad, IBrandFacad brandFacad)
        {
            _categoryFacad = categoryFacad;
            _brandFacad = brandFacad;
            _productFacad = productFacad;

            RuleFor(p => p.Title)
                .NotNull().WithMessage("نام محصول اجباریست")
                .NotEmpty().WithMessage("نام محصول اجباریست");

            RuleFor(p => p.ShortDescription)
                .NotNull().WithMessage("توضیحات مختصر برای محصول اجباریست")
                .NotEmpty().WithMessage("توضیحات مختصر برای محصول اجباریست");

            RuleFor(p => p.Description)
                .NotNull().WithMessage("توضیحات برای محصول اجباریست")
                .NotEmpty().WithMessage("توضیحات برای محصول اجباریست");

            RuleFor(p => p.DiscountAmount)
                .GreaterThanOrEqualTo(0).WithMessage("مقدار تخفیف نمیتواند منفی باشد");

            RuleFor(p => p.Inventory)
                .GreaterThanOrEqualTo(0).WithMessage("مقدار موجودی نمیتواند منفی باشد");

            RuleFor(p => p.Price)
                .GreaterThanOrEqualTo(0).WithMessage("قیمت نمیتواند منفی باشد");

            RuleFor(p => p.MainImage)
                .NotNull().WithMessage("حداقل یک تصویر باید انتخاب شود");

            RuleFor(p => p.CategoryId)
                .Must(CategoryIdValidation).WithMessage("لطفا دسته بندی را انتخاب نمایید");

            RuleFor(p => p.GroupId)
                 .Must(GroupIdValidation).WithMessage("لطفا گروه را انتخاب نمایید");

            RuleFor(p => p.SubGroupId)
                 .Must(SubGroupIdValidation).WithMessage("لطفا زیرگروه را انتخاب نمایید");

            RuleFor(p => p.BrandId)
                 .Must(BrandIdValidation).WithMessage("لطفا برند محصول را انتخاب نمایید");

            RuleFor(p => p.Title)
                 .Must(TitleValidation).WithMessage("محصولی با این نام قبلا ثبت شده");

            RuleFor(p => p.Tags)
                .Matches(@"^[a-z0-9A-Z\u0600-\u06FF\s _-]+$").WithMessage("فقط از اعداد و حروف فارسی و انگلیسی و _ و - میتوانید استفاده کنید");
        }

        private bool CategoryIdValidation(int id)
        {
            catId = id;
            return _categoryFacad.isExistCategoryService.Execute(id).Data;
        }

        private bool GroupIdValidation(int id)
        {
            grpId = id;
            var categories = _categoryFacad.GetCategoriesForAdminService.Execute(catId, IgnoreFilters: false).Data;
            return categories.Any(c => c.Id.Equals(id));
        }

        private bool SubGroupIdValidation(int id)
        {
            var categories = _categoryFacad.GetCategoriesForAdminService.Execute(grpId, IgnoreFilters: false).Data;
            return categories.Any(c => c.Id.Equals(id));
        }
        private bool BrandIdValidation(int id)
        {
            return _brandFacad.IsExistBrandService.Execute(id).Data;
        }
        private bool TitleValidation(string title)
        {
            var res = !_productFacad.isExistProductService.Execute(title).Data;
            return true;
        }
    }
}

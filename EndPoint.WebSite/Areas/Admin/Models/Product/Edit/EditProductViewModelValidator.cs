using FluentValidation;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;

namespace EndPoint.WebSite.Areas.Admin.Models.Product.Edit
{
    public class EditProductViewModelValidator : AbstractValidator<EditProductViewModel>
    {
        private readonly IProductFacad _productFacad;
        private readonly ICategoryFacad _categoryFacad;
        private readonly IBrandFacad _brandFacad;

        private int catId = 0;
        private int grpId = 0;
        private int productId = 0;

        public EditProductViewModelValidator(IProductFacad productFacad, ICategoryFacad categoryFacad, IBrandFacad brandFacad)
        {
            _categoryFacad = categoryFacad;
            _brandFacad = brandFacad;
            _productFacad = productFacad;

            RuleFor(p => p.Id)
                .Must(IdValidation);

            RuleFor(p => p.Title)
                .NotNull().WithMessage("نام محصول اجباریست")
                .NotEmpty().WithMessage("نام محصول اجباریست")
                .Must(TitleValidation).WithMessage("محصولی با این نام قبلا ثبت شده");

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

            RuleFor(p => p.CategoryId)
                .Must(CategoryIdValidation).WithMessage("لطفا دسته بندی را انتخاب نمایید");

            RuleFor(p => p.GroupId)
                 .Must(GroupIdValidation).WithMessage("لطفا گروه را انتخاب نمایید");

            RuleFor(p => p.SubgroupId)
                 .Must(SubGroupIdValidation).WithMessage("لطفا زیرگروه را انتخاب نمایید");

            RuleFor(p => p.BrandId)
                 .Must(BrandIdValidation).WithMessage("لطفا برند محصول را انتخاب نمایید");
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
        private bool IdValidation(int id)
        {
            productId = id;
            return true;
        }

        private bool TitleValidation(string title)
        {
            return !_productFacad.isExistProductService.Execute(title, productId).Data;
        }

    }
}

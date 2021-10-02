using FluentValidation;
using Store_Application.Application.Interfaces.FacadPattern;

namespace EndPoint.WebSite.Models.Comment.Add
{
    public class AddCommentViewModelValidator : AbstractValidator<AddCommentViewModel>
    {
        private readonly IProductFacad _productFacad;
        public AddCommentViewModelValidator(IProductFacad productFacad)
        {
            _productFacad = productFacad;

            RuleFor(x => x.ProductId)
                .Must(ProductIdValidator).WithMessage("محصولی برای ثبت نظر نظر یافت نشد");

            RuleFor(x => x.Title)
                .NotNull().WithMessage("لطفا عنوان را وارد کنید")
                .NotEmpty().WithMessage("لطفا عنوان را وارد کنید");

            RuleFor(x => x.Text)
                .NotNull().WithMessage("لطفا نظر خود را وارد کنید")
                .NotEmpty().WithMessage("لطفا نظر خود را وارد کنید");

            RuleFor(x => x.Rate)
               .InclusiveBetween((byte)1, (byte)5).WithMessage("لطفا امتیاز خود به این محصول را تعیین کنید");

            RuleFor(x => x.IRecommend)
                .NotNull().WithMessage("لطفا مشخص کنید این محصول را پیشنهاد میکنید یا خیر")
                .Must(IRecommendValidator).WithMessage("لطفا مشخص کنید این محصول را پیشنهاد میکنید یا خیر");

        }

        private bool ProductIdValidator(int productId)
        {
            var isExist = _productFacad.isExistProductService.Execute(productId);

            return isExist.Data;
        }
        private bool IRecommendValidator(string Irecommend)
        {
            if (Irecommend.Equals("بله") || Irecommend.Equals("خیر"))
            {
                return true;
            }

            return false;
        }
    }
}


using FluentValidation;
using Store_Application.Application.Interfaces.FacadPattern;

namespace EndPoint.WebSite.Models.Comment.DislikeComment
{
    public class DislikeCommentViewModelValidator : AbstractValidator<DislikeCommentViewModel>
    {
        private readonly IProductFacad _productFacad;
        private readonly ICommentFacad _commentFacad;

        public DislikeCommentViewModelValidator(IProductFacad productFacad, ICommentFacad commentFacad)
        {
            _productFacad = productFacad;
            _commentFacad = commentFacad;
            RuleFor(x => x.ProductId)
                .Must(ProductIdValidator).WithMessage("محصولی برای ثبت نظر نظر یافت نشد");

            RuleFor(x => x.CommentId)
                .Must(CommentIdValidator).WithMessage("نظر کاربر مور نظر شما یافت نشد");
        }

        private bool ProductIdValidator(int productId)
        {
            var isExist = _productFacad.isExistProductService.Execute(productId);

            return isExist.Data;
        }
        private bool CommentIdValidator(int commentId)
        {
            var isExist = _commentFacad.IsExistCommentService.Execute(commentId);

            return isExist.Data;
        }
    }
}

using FluentValidation;
using Store_Application.Application.Interfaces.FacadPattern;

namespace EndPoint.WebSite.Models.Question.Add
{
    public class AddQuestionViewModelValidator : AbstractValidator<AddQuestionViewModel>
    {
        private readonly IProductFacad _productFacad;
        private readonly IQuestionFacad _questionFacad;
        public AddQuestionViewModelValidator(IProductFacad productFacad, IQuestionFacad questionFacad)
        {
            _productFacad = productFacad;
            _questionFacad = questionFacad;

            RuleFor(x => x.ProductId)
                .Must(ProductIdValidator).WithMessage("محصولی برای ثبت نظر نظر یافت نشد");

            RuleFor(x => x.ParentId)
                .Must(ParentIdValidator).WithMessage("کامنتی برای پاسخ یافت نشد");

            RuleFor(x => x.Text)
                .NotNull().WithMessage("لطفا سوال خود را وارد کنید")
                .NotEmpty().WithMessage("لطفا سوال خود را وارد کنید");
        }

        private bool ProductIdValidator(int productId)
        {
            var isExist = _productFacad.isExistProductService.Execute(productId);

            return isExist.Data;
        }

        private bool ParentIdValidator(int? parentId)
        {
            var isExist = true;
            if (parentId != null)
                isExist = _questionFacad.IsExisQuesionService.Execute(parentId).Data;

            return isExist;
        }
    }
}

using EndPoint.WebSite.Models.Question.Add;
using EndPoint.WebSite.Models.Question.LoadQuestions;
using EndPoint.WebSite.Utilities;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Question.Commands.AddQuestion;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionFacad _questionFacad;
        private readonly IProductFacad _productFacad;
        private readonly ClaimUtility _claimUtility;
        public QuestionController(IQuestionFacad questionFacad,
            IProductFacad productFacad,
            ClaimUtility claimUtility)
        {
            _questionFacad = questionFacad;
            _productFacad = productFacad;
            _claimUtility = claimUtility;
        }

        [HttpPost]
        public PartialViewResult LoadQuestions(int productId, int page, int take)
        {
            var res = _questionFacad.GetQuestionsService.Execute(productId, page, take);

            var model = new List<LoadQuestionsViewModel>();

            if (res.IsSuccess)
            {
                model = res.Data.Select(q => new LoadQuestionsViewModel
                {
                    Id = q.Id,
                    InsertTime = q.InsertTime,
                    ParentQuestionId = q.ParentQuestionId,
                    Text = q.Text,
                    UserId = q.User.Id,
                    Username = q.User.Username
                }).OrderBy(q => q.InsertTime).ToList();
            }

            if (_claimUtility.IsAuthenticated(User))
            {
                ViewBag.UserId = _claimUtility.GetUserId(User);
            }

            return PartialView("/Views/Question/_LoadQuestions.cshtml", model);
        }

        [HttpPost]
        public IActionResult Add(AddQuestionViewModel req)
        {
            var RequestValidation = new AddQuestionViewModelValidator(_productFacad, _questionFacad);
            var Validation = RequestValidation.Validate(req);
            Validation.AddToModelState(ModelState, null);

            ResultDto res = new ResultDto();

            if (!ModelState.IsValid)
            {
                res.Message = ModelState.Values.Single(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                    .Errors.First().ErrorMessage;
                res.IsSuccess = false;
                return Json(res);
            }

            res = _questionFacad.AddQuestionService.Execute(new RequestAddQuestionDto
            {
                ProductId = req.ProductId,
                UserId = _claimUtility.GetUserId(User),
                Text = req.Text.Trim(),
                ParentQuestionId = req.ParentId
            });

            return Json(res);
        }

    }
}

using EndPoint.WebSite.Areas.Admin.Models.Common;
using EndPoint.WebSite.Areas.Admin.Models.Question.LoadQuestions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Question.Queries.GetQuestionsForAdmin;
using Store_Application.Domain.Enums;
using System;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + "," + nameof(Roles.Operator))]

    public class QuestionController : Controller
    {
        private readonly IQuestionFacad _questionFacad;
        public QuestionController(IQuestionFacad questionFacad)
        {
            _questionFacad = questionFacad;
        }

        public IActionResult Index(RequestLoadQuestionsViewModel req)
        {
            ViewBag.page = req.Page;
            ViewBag.take = req.Take;
            ViewBag.searchKey = req.Searchkey;

            req.BinSearchValuesToFields();

            return View(req);
        }

        [HttpPost]
        public PartialViewResult LoadQuestions(RequestLoadQuestionsViewModel req)
        {
            ViewBag.page = req.Page;
            ViewBag.take = req.Take;
            ViewBag.searchKey = $"{req.QuestionId},{req.ProductId},{req.UserId},{(int)req.Status},{req.FromDate},{req.ToDate}";

            bool? confirmed = null;

            if (req.Status == QuestionStatus.Confirmed)
                confirmed = true;
            else if (req.Status == QuestionStatus.Unconfirmed)
                confirmed = false;

            var res = _questionFacad.GetQuestionsForAdminService.Execute(new RequestGetQuestionsForAdminDto()
            {
                Page = req.Page,
                Take = req.Take,
                UserId = req.UserId,
                ProductId = req.ProductId,
                QuestionId = req.QuestionId,
                Confirmed = confirmed,
                ToDate = req.ToDate,
                FromDate = req.FromDate
            });

            var model = new LoadQuestionsViewModel();

            if (res.IsSuccess)
            {
                model.Questions = res.Data.Questions.Select(c => new QuestionViewModel()
                {
                    Id = c.Id,
                    Text = c.Text,
                    ParentQuestionId = c.ParentQuestionId,
                    parentQuestionText = c.parentQuestionText,
                    Confirmed = c.Confirmed,
                    UserId = c.UserId,
                    ProductId = c.ProductId,
                    InsertTime = c.InsertTime,
                }).ToList();
            }

            model.Paging = new PagingViewModel
            {
                CurrentPage = res.Data.CurrentPage,
                PageCount = res.Data.PageCount
            };

            return PartialView("/Areas/Admin/Views/Question/_LoadQuestions.cshtml", model);
        }

        [HttpPost]
        public IActionResult ChangeStatus(int questionId)
        {

            var res = _questionFacad.ChangeStatusForAdminService.Execute(questionId);

            return Json(res);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Areas.UserPanel.Models.Question.Index;
using EndPoint.WebSite.Utilities;
using Store_Application.Application.Interfaces.FacadPattern;

namespace EndPoint.WebSite.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class QuestionController : Controller
    {
        private readonly IQuestionFacad _questionFacad;
        private readonly ClaimUtility _claimUtility;
        public QuestionController(IQuestionFacad questionFacad, ClaimUtility claimUtility)
        {
            _questionFacad = questionFacad;
            _claimUtility = claimUtility;
        }

        public IActionResult Index()
        {
            int userId = _claimUtility.GetUserId(User);

            var res = _questionFacad.GetUserQuestionService.Execute(userId);

            var model = new List<UserQuestionViewModel>();

            if (res.IsSuccess)
            {
                model = res.Data.Select(c => new UserQuestionViewModel()
                {
                    Id = c.Id,
                    ConfirmedByAdmin = c.ConfirmedByAdmin,
                    ProductId = c.ProductId,
                    Text = c.Text,
                    ParentQuestionText = c.ParentQuestionText,
                    AdminIsRead = c.AdminIsRead,
                    Product = new ProductViewModel()
                    {
                        Id = c.Product.Id,
                        Title = c.Product.Title,
                        ImageName = c.Product.ImageName
                    }
                }).ToList();
            }

            return View(model);
        }

        public IActionResult RemoveQuestion(int questionId)
        {
            int userId = _claimUtility.GetUserId(User);

            var res = _questionFacad.RemoveQuestionService.Execute(userId, questionId);

            return Json(res);
        }
    }
}

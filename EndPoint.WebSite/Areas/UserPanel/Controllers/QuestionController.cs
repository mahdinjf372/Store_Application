using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Areas.UserPanel.Models.Question.Index;
using EndPoint.WebSite.Utilities;
using Store_Application.Application.Interfaces.FacadPattern;
using AutoMapper;

namespace EndPoint.WebSite.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class QuestionController : Controller
    {
        private readonly IQuestionFacad _questionFacad;
        private readonly ClaimUtility _claimUtility;
        private readonly IMapper _mapper;
        public QuestionController(IQuestionFacad questionFacad,
            ClaimUtility claimUtility,
            IMapper mapper)
        {
            _questionFacad = questionFacad;
            _claimUtility = claimUtility;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            int userId = _claimUtility.GetUserId(User);

            var res = _questionFacad.GetUserQuestionService.Execute(userId);

            var model = new List<UserQuestionViewModel>();

            if (res.IsSuccess)
            {
                model = _mapper.Map<List<UserQuestionViewModel>>(res.Data);
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

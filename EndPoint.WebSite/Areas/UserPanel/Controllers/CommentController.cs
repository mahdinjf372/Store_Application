using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Areas.UserPanel.Models.Comment.Index;
using EndPoint.WebSite.Utilities;
using Store_Application.Application.Interfaces.FacadPattern;
using AutoMapper;

namespace EndPoint.WebSite.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class CommentController : Controller
    {
        private readonly ICommentFacad _commentFacad;
        private readonly ClaimUtility _claimUtility;
        private readonly IMapper _mapper;
        public CommentController(ICommentFacad commentFacad, ClaimUtility claimUtility, IMapper mapper)
        {
            _commentFacad = commentFacad;
            _claimUtility = claimUtility;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            int userId = _claimUtility.GetUserId(User);

            var res = _commentFacad.GetUserCommentsService.Execute(userId);

            var model = new List<UserCommentViewModel>();

            if (res.IsSuccess)
            {
                model = _mapper.Map<List<UserCommentViewModel>>(res.Data);
            }

            return View(model);
        }

        public IActionResult RemoveComment(int commentId)
        {
            int userId = _claimUtility.GetUserId(User);

            var res = _commentFacad.RemoveCommentService.Execute(userId, commentId);

            return Json(res);

        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EndPoint.WebSite.Areas.UserPanel.Models.Comment.Index;
using EndPoint.WebSite.Utilities;
using Store_Application.Application.Interfaces.FacadPattern;

namespace EndPoint.WebSite.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class CommentController : Controller
    {
        private readonly ICommentFacad _commentFacad;
        private readonly ClaimUtility _claimUtility;
        public CommentController(ICommentFacad commentFacad, ClaimUtility claimUtility)
        {
            _commentFacad = commentFacad;
            _claimUtility = claimUtility;
        }

        public IActionResult Index()
        {
            int userId = _claimUtility.GetUserId(User);

            var res = _commentFacad.GetUserCommentsService.Execute(userId);

            var model = new List<UserCommentViewModel>();

            if (res.IsSuccess)
            {
                model = res.Data.Select(c => new UserCommentViewModel()
                {
                    Id = c.Id,
                    ConfirmedByAdmin = c.ConfirmedByAdmin,
                    ProductId = c.ProductId,
                    Rate = c.Rate,
                    Recommend = c.Recommend,
                    Title = c.Title,
                    Text = c.Text,
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

        public IActionResult RemoveComment(int commentId)
        {
            int userId = _claimUtility.GetUserId(User);

            var res = _commentFacad.RemoveCommentService.Execute(userId, commentId);

            return Json(res);

        }

    }
}

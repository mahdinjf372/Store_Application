using EndPoint.WebSite.Areas.Admin.Models.Comment.LoadComments;
using EndPoint.WebSite.Areas.Admin.Models.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Comment.Queries.GetCommentsForAdmin;
using Store_Application.Domain.Enums;
using System;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = nameof(Roles.Admin) + "," + nameof(Roles.Operator))]
    public class CommentController : Controller
    {
        private readonly ICommentFacad _commentFacad;
        public CommentController(ICommentFacad commentFacad)
        {
            _commentFacad = commentFacad;
        }

        public IActionResult Index(RequestLoadCommentsViewModel req)
        {
            ViewBag.page = req.Page;
            ViewBag.take = req.Take;
            ViewBag.searchKey = req.Searchkey; 
            
            req.BinSearchValuesToFields();

            return View(req);
        }

        [HttpPost]
        public PartialViewResult LoadComments(RequestLoadCommentsViewModel req)
        {
            ViewBag.page = req.Page;
            ViewBag.take = req.Take;
            ViewBag.searchKey = $"{req.CommentId},{req.ProductId},{req.UserId},{(int)req.Status},{req.FromDate},{req.ToDate}";

            bool? confirmed = null;

            if (req.Status == CommentStatus.Confirmed)
                confirmed = true;
            else if (req.Status == CommentStatus.Unconfirmed)
                confirmed = false;

            var res = _commentFacad.GetCommentsForAdminService.Execute(new RequestGetCommentsForAdminDto()
            {
                Page = req.Page,
                Take = req.Take,
                UserId = req.UserId,
                ProductId = req.ProductId,
                CommentId = req.CommentId,
                Confirmed = confirmed,
                ToDate = req.ToDate,
                FromDate = req.FromDate
            });

            var model = new LoadCommentsViewModel();

            if (res.IsSuccess)
            {
                model.Comments = res.Data.Comments.Select(c => new CommentViewModel()
                {
                    Id = c.Id,
                    Title = c.Title,
                    Text = c.Text,
                    Rate = c.Rate,
                    Confirmed = c.Confirmed,
                    Recommend = c.Recommend,
                    UserId = c.UserId,
                    ProductId = c.ProductId,
                    InsertTime = c.InsertTime,
                    LikesCount = c.LikesCount,
                    DislikesCount = c.DislikesCount
                }).ToList();
            }

            model.Paging = new PagingViewModel
            {
                CurrentPage = res.Data.CurrentPage,
                PageCount = res.Data.PageCount
            };

            return PartialView("/Areas/Admin/Views/Comment/_LoadComments.cshtml", model);
        }

        [HttpPost]
        public IActionResult ChangeStatus(int commentId)
        {

            var res = _commentFacad.ChangeStatusForAdminService.Execute(commentId);

            return Json(res);
        }
    }
}

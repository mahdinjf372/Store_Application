using EndPoint.WebSite.Areas.Admin.Models.Comment.LoadComments;
using EndPoint.WebSite.Areas.Admin.Models.Common;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Comment.Queries.GetCommentsForAdmin;
using System;
using System.Linq;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
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

            string[] filters = new string[6];
            filters = req.Searchkey?.Split(',');

            if (filters != null && !string.IsNullOrEmpty(filters[0]))
                req.CommentId = int.Parse(filters[0]);

            if (filters != null && !string.IsNullOrEmpty(filters[1]))
                req.ProductId = int.Parse(filters[1]);

            if (filters != null && !string.IsNullOrEmpty(filters[2]))
                req.UserId = int.Parse(filters[2]);

            if (filters != null && !string.IsNullOrEmpty(filters[4]))
                req.FromDate = DateTime.Parse(filters[4]);

            if (filters != null && !string.IsNullOrEmpty(filters[5]))
                req.ToDate = DateTime.Parse(filters[5]);

            switch (filters?[3])
            {
                case "0":
                    req.Status = CommentStatus.None;
                    break;
                case "1":
                    req.Status = CommentStatus.Confirmed;
                    break;
                case "2":
                    req.Status = CommentStatus.Unconfirmed;
                    break;
            }

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

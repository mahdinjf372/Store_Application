using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common;
using Store_Application.Common.Extentions;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Comment.Queries.GetCommentsForAdmin
{
    public class GetCommentsForAdminService : IGetCommentsForAdminService
    {

        private readonly IDataBaseContext _db;
        public GetCommentsForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetCommentsForAdminDto> Execute(RequestGetCommentsForAdminDto req)
        {
            try
            {
                var comments = _db.Comments.IgnoreQueryFilters().AsQueryable();

                comments = ApplyFilters(comments, req);

                var usersViewModel = comments
                    .Include(c => c.Likes)
                    .Include(c => c.Dislikes)
                    .Select(c => new CommentsForAdminDto()
                    {
                        Id = c.Id,
                        Title = c.Title,
                        Text = c.Text,
                        Rate = c.Rate,
                        Confirmed = c.ConfirmedByAdmin,
                        Recommend = c.IRecommended,
                        UserId = c.UserId,
                        ProductId = c.ProductId,
                        InsertTime = c.InsertTime,
                        LikesCount = c.Likes.Count(l => !l.isRemoved),
                        DislikesCount = c.Dislikes.Count(d => !d.isRemoved)
                    })
                    .ToPaged(req.Page, req.Take, out var rowCount).ToList();

                double ee = ((double)rowCount) / ((double)req.Take);
                int pageCount = (int)Math.Ceiling(ee);

                var resultGetUsers = new ResultGetCommentsForAdminDto()
                {
                    CurrentPage = req.Page,
                    PageCount = pageCount,
                    Comments = usersViewModel
                };

                return new ResultDto<ResultGetCommentsForAdminDto>()
                {
                    Data = resultGetUsers,
                    IsSuccess = true,
                    Message = "عملیات واکشی نظرات با موفقیت انجام شد"
                };
            }
            catch (Exception e)
            {
                return new ResultDto<ResultGetCommentsForAdminDto>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "عملیات واکشی نظرات با شکست مواجه شد"
                };
            }
        }

        private IQueryable<Domain.Entities.Comment.Comment> ApplyFilters(IQueryable<Domain.Entities.Comment.Comment> query, RequestGetCommentsForAdminDto req)
        {
            var res = query;

            if (req.CommentId != null)
            {
                res = res.Where(c => c.Id == req.CommentId).AsQueryable();
            }
            if (req.UserId != null)
            {
                res = res.Where(c => c.UserId == req.UserId).AsQueryable();
            }
            if (req.ProductId != null)
            {
                res = res.Where(c => c.ProductId == req.ProductId).AsQueryable();
            }
            if (req.Confirmed != null)
            {
                res = res.Where(c => c.ConfirmedByAdmin == req.Confirmed).AsQueryable();
            }
            if (req.FromDate != null)
            {
                DateTime fromDate = (DateTime) req.FromDate;
                res = res.Where(c => c.InsertTime >= fromDate.ToMiladi()).AsQueryable();
            }
            if (req.ToDate != null)
            {
                DateTime toDate = (DateTime)req.ToDate?.ToMiladi();
                DateTime endDate = new DateTime(toDate.Year,toDate.Month, toDate.Day,23,59,59);
                
                res = res.Where(c => c.InsertTime <= endDate).AsQueryable();
            }


            return res;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common;
using Store_Application.Common.Extentions;
using Store_Application.Common.ViewModels;
using System;
using System.Linq;

namespace Store_Application.Application.Services.Question.Queries.GetQuestionsForAdmin
{
    public class GetQuestionsForAdminService : IGetQuestionsForAdminService
    {

        private readonly IDataBaseContext _db;
        public GetQuestionsForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<ResultGetQuestionsForAdminDto> Execute(RequestGetQuestionsForAdminDto req)
        {
            try
            {
                var questions = _db.Questions.IgnoreQueryFilters().AsQueryable();

                questions = ApplyFilters(questions, req);

                var questionsViewModel = questions
                    .Include(c=>c.ParentQuestion)
                    .Select(c => new QuestionsForAdminDto()
                    {
                        Id = c.Id,
                        Text = c.Text,
                        parentQuestionText = (c.ParentQuestionId != null)? c.ParentQuestion.Text : null,
                        ParentQuestionId = c.ParentQuestionId,
                        Confirmed = c.ConfirmedByAdmin,
                        UserId = c.UserId,
                        ProductId = c.ProductId,
                        InsertTime = c.InsertTime,
                    })
                    .ToPaged(req.Page, req.Take, out var rowCount).ToList();

                double ee = ((double)rowCount) / ((double)req.Take);
                int pageCount = (int)Math.Ceiling(ee);

                var resultGetQuestions = new ResultGetQuestionsForAdminDto()
                {
                    CurrentPage = req.Page,
                    PageCount = pageCount,
                    Questions = questionsViewModel
                };

                return new ResultDto<ResultGetQuestionsForAdminDto>()
                {
                    Data = resultGetQuestions,
                    IsSuccess = true,
                    Message = "عملیات واکشی پرسش و پاسخ با موفقیت انجام شد"
                };
            }
            catch (Exception e)
            {
                return new ResultDto<ResultGetQuestionsForAdminDto>()
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "عملیات واکشی پرسش و پاسخ با شکست مواجه شد"
                };
            }
        }

        private IQueryable<Domain.Entities.Question.Question> ApplyFilters(IQueryable<Domain.Entities.Question.Question> query, RequestGetQuestionsForAdminDto req)
        {
            var res = query;

            if (req.QuestionId != null)
            {
                res = res.Where(c => c.Id == req.QuestionId).AsQueryable();
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
                DateTime fromDate = (DateTime)req.FromDate;
                res = res.Where(c => c.InsertTime >= fromDate.ToMiladi()).AsQueryable();
            }
            if (req.ToDate != null)
            {
                DateTime toDate = (DateTime)req.ToDate?.ToMiladi();
                DateTime endDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59);

                res = res.Where(c => c.InsertTime <= endDate).AsQueryable();
            }

            return res;
        }
    }
}

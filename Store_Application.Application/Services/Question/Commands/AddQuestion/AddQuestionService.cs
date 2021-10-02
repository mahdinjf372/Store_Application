using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Question.Commands.AddQuestion
{
    public class AddQuestionService : IAddQuestionService
    {
        private readonly IDataBaseContext _db;
        public AddQuestionService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(RequestAddQuestionDto req)
        {
            var question = new Domain.Entities.Question.Question();

            question.InsertTime = DateTime.Now;
            question.ParentQuestionId = req.ParentQuestionId;
            question.ProductId = req.ProductId;
            question.UserId = req.UserId;
            question.Text = req.Text;

            try
            {
                _db.Questions.Add(question);
                _db.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = req.ParentQuestionId != null? "پاسخ شما با موفقیت ثبت شد" : "سوال شما با موفقیت ثبت شد"
                };
            }
            catch (Exception)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = req.ParentQuestionId != null ? "ثبت پاسخ شما ا شکست مواجه شد" : "ثبت سوال شما با شکست مواجه شد"
                };
            }
        }
    }
}

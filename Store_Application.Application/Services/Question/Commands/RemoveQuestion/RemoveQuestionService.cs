using System;
using System.Linq;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Question.Commands.RemoveQuestion
{
    public class RemoveQuestionService : IRemoveQuestionService
    {
        private readonly IDataBaseContext _db;
        public RemoveQuestionService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int userId, int questionId)
        {
            var question = _db.Questions.SingleOrDefault(c => c.UserId == userId && c.Id == questionId);

            var res = new ResultDto();
            res.IsSuccess = false;

            if (question != null)
            {
                question.isRemoved = true;
                question.RemovedTime = DateTime.Now;
                _db.Questions.Update(question);
                _db.SaveChanges();

                res.IsSuccess = true;
            }

            return res;
        }
    }
}
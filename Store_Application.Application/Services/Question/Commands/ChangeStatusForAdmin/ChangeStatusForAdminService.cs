using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System;

namespace Store_Application.Application.Services.Question.Commands.ChangeStatusForAdmin
{
    public class ChangeStatusForAdminService : IChangeStatusForAdminService
    {
        private readonly IDataBaseContext _db;
        public ChangeStatusForAdminService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto Execute(int questionId)
        {
            var question = _db.Questions.Find(questionId);

            question.AdminIsRead = true;
            question.ConfirmedByAdmin = !question.ConfirmedByAdmin;
            question.UpdateTime = DateTime.Now;

            _db.Questions.Update(question);
            _db.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = $"وضعیت پرسش و پاسخ {questionId} با موفقیت تغییر یافت"
            };
        }
    }
}

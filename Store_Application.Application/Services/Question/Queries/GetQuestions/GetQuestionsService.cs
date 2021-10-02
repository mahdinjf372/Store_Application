using Microsoft.EntityFrameworkCore;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Store_Application.Common;

namespace Store_Application.Application.Services.Question.Queries.GetQuestions
{
    public class GetQuestionsService : IGetQuestionsService
    {
        private readonly IDataBaseContext _db;
        public GetQuestionsService(IDataBaseContext db)
        {
            _db = db;
        }

        public ResultDto<List<ResultGetQuestionsDto>> Execute(int productId, int page, int take = 10)
        {
            List<ResultGetQuestionsDto> questions = new List<ResultGetQuestionsDto>();

            for (int i = (page-1)*take ; i < ((page - 1) * take) + take; i++)
            {
                ResultGetQuestionsDto question = _db.Questions
                    .Where(q => q.AdminIsRead && q.ConfirmedByAdmin && q.ProductId.Equals(productId) && q.ParentQuestionId==null)
                    .Include(q => q.User)
                    .Select(q => new ResultGetQuestionsDto
                    {
                        Id = q.Id,
                        InsertTime = q.InsertTime,
                        ParentQuestionId = null,
                        Text = q.Text,
                        User = new UserDto
                        {
                            Id = q.UserId,
                            Username = q.User.Username,
                            Email = q.User.Email
                        }
                    }).OrderBy(q => q.InsertTime).Skip(i).Take(1).FirstOrDefault();

                if (question == null)
                    break;

                questions.Add(question);

                List<ResultGetQuestionsDto> replays = _db.Questions
                    .Where(q => q.AdminIsRead && q.ConfirmedByAdmin && q.ProductId.Equals(productId) && q.ParentQuestionId.Equals(question.Id))
                    .Include(q => q.User)
                    .Select(q => new ResultGetQuestionsDto
                    {
                        Id = q.Id,
                        InsertTime = q.InsertTime,
                        ParentQuestionId = q.ParentQuestionId,
                        Text = q.Text,
                        User = new UserDto
                        {
                            Id = q.UserId,
                            Username = q.User.Username,
                            Email = q.User.Email
                        }
                    }).OrderBy(q => q.InsertTime).ToList();

                questions.AddRange(replays);
            }

            foreach (var question in questions)
            {
                if (string.IsNullOrEmpty(question.User.Username))
                {
                    question.User.Username = question.User.Email.Split("@")[0];
                }
            }

            return new ResultDto<List<ResultGetQuestionsDto>>
            {
                Data = questions,
                IsSuccess = true
            };
        }
    }
}

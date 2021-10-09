using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Question.Queries.GetUserQuestions
{
    public interface IGetUserQuestionService
    {
        ResultDto<List<ResultGetUserQuestionDto>> Execute(int userId);
    }
}

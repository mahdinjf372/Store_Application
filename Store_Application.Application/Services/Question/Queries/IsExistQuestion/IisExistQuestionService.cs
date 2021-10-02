using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Question.Queries.IsExistQuestion
{
    public interface IisExistQuestionService
    {
        ResultDto<bool> Execute(int? Id);
    }
}

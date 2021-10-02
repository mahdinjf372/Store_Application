using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Question.Queries.GetQuestions
{
    public interface IGetQuestionsService
    {
        ResultDto<List<ResultGetQuestionsDto>> Execute(int productId, int page, int take = 10);

    }
}

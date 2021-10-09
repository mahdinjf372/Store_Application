using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Question.Commands.RemoveQuestion
{
    public interface IRemoveQuestionService
    {
        ResultDto Execute(int userId, int questionId);
    }
}

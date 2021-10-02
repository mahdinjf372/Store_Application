using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Domain.Entities.Question;

namespace Store_Application.Application.Services.Question.Commands.AddQuestion
{
    public interface IAddQuestionService
    {
        ResultDto Execute(RequestAddQuestionDto req); 
    }
}

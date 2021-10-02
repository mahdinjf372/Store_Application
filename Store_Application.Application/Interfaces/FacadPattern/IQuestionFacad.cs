using Store_Application.Application.Services.Question.Commands.AddQuestion;
using Store_Application.Application.Services.Question.Queries.GetQuestions;
using Store_Application.Application.Services.Question.Queries.IsExistQuestion;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IQuestionFacad
    {
        IAddQuestionService AddQuestionService { get; }
        IGetQuestionsService GetQuestionsService { get; }
        IisExistQuestionService IsExisQuesionService { get; }
    }
}

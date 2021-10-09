using Store_Application.Application.Services.Question.Commands.AddQuestion;
using Store_Application.Application.Services.Question.Commands.ChangeStatusForAdmin;
using Store_Application.Application.Services.Question.Commands.RemoveQuestion;
using Store_Application.Application.Services.Question.Queries.GetQuestions;
using Store_Application.Application.Services.Question.Queries.GetQuestionsForAdmin;
using Store_Application.Application.Services.Question.Queries.GetUserQuestions;
using Store_Application.Application.Services.Question.Queries.IsExistQuestion;

namespace Store_Application.Application.Interfaces.FacadPattern
{
    public interface IQuestionFacad
    {
        IAddQuestionService AddQuestionService { get; }
        IGetQuestionsService GetQuestionsService { get; }
        IisExistQuestionService IsExisQuesionService { get; }
        IGetUserQuestionService GetUserQuestionService { get; }
        IRemoveQuestionService RemoveQuestionService { get; }
        IGetQuestionsForAdminService GetQuestionsForAdminService { get; }
        IChangeStatusForAdminService ChangeStatusForAdminService { get; }
    }
}

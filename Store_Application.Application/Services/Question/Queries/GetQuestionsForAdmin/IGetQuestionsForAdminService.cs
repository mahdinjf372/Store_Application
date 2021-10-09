using Store_Application.Common.ViewModels;

namespace Store_Application.Application.Services.Question.Queries.GetQuestionsForAdmin
{
    public interface IGetQuestionsForAdminService
    {
        ResultDto<ResultGetQuestionsForAdminDto> Execute(RequestGetQuestionsForAdminDto req);
    }
}

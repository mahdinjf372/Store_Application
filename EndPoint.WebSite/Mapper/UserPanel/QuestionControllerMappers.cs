using AutoMapper;
using EndPoint.WebSite.Areas.UserPanel.Models.Question.Index;
using Store_Application.Application.Services.Orders.Queries.GetOrderForUserPanel;
using Store_Application.Application.Services.Question.Queries.GetUserQuestions;

namespace EndPoint.WebSite.Mapper.UserPanel
{
    public class QuestionControllerMappers : Profile
    {
        public QuestionControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<ResultGetUserQuestionDto, UserQuestionViewModel>();
            CreateMap<ProductDto, ProductViewModel>();


        }
    }
}

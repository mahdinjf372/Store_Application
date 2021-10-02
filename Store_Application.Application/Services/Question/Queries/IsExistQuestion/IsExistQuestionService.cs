using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using System.Linq;

namespace Store_Application.Application.Services.Question.Queries.IsExistQuestion
{
    public class IsExistQuestionService : IisExistQuestionService
    {
        private readonly IDataBaseContext _db;
        public IsExistQuestionService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<bool> Execute(int? Id)
        {
            var isExist = _db.Questions.Any(q => q.Id.Equals(Id));

            return new ResultDto<bool>
            {
                Data = isExist,
                IsSuccess = true,
            };
        }
    }
}

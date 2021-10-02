using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Question.Commands.AddQuestion;
using Store_Application.Application.Services.Question.Queries.GetQuestions;
using Store_Application.Application.Services.Question.Queries.IsExistQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Question.FacadPattern
{
    public class QuestionFacad : IQuestionFacad
    {
        private readonly IDataBaseContext _db;
        public QuestionFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IAddQuestionService _addQuestionService;
        public IAddQuestionService AddQuestionService
        {
            get
            {
                return _addQuestionService = _addQuestionService ?? new AddQuestionService(_db);
            }
        }


        private IGetQuestionsService _getQuestionsService;
        public IGetQuestionsService GetQuestionsService
        {
            get
            {
                return _getQuestionsService = _getQuestionsService ?? new GetQuestionsService(_db);
            }
        }
        

        private IisExistQuestionService _isExisQuesionService;
        public IisExistQuestionService IsExisQuesionService
        {
            get
            {
                return _isExisQuesionService = _isExisQuesionService ?? new IsExistQuestionService(_db);
            }
        }
    }
}

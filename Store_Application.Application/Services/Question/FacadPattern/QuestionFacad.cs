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
using Store_Application.Application.Services.Question.Commands.RemoveQuestion;
using Store_Application.Application.Services.Question.Queries.GetUserQuestions;
using Store_Application.Application.Services.Question.Queries.GetQuestionsForAdmin;
using Store_Application.Application.Services.Question.Commands.ChangeStatusForAdmin;

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

        private IGetUserQuestionService _getUserQuestionService;
        public IGetUserQuestionService GetUserQuestionService
        {
            get
            {
                return _getUserQuestionService ??= new GetUserQuestionService(_db);
            }
        }

        private IRemoveQuestionService _removeQuestionService;
        public IRemoveQuestionService RemoveQuestionService
        {
            get
            {
                return _removeQuestionService ??= new RemoveQuestionService(_db);
            }
        }

        private IGetQuestionsForAdminService _getQuestionsForAdminService;
        public IGetQuestionsForAdminService GetQuestionsForAdminService
        {
            get
            {
                return _getQuestionsForAdminService ??= new GetQuestionsForAdminService(_db);
            }
        }

        private IChangeStatusForAdminService _changeStatusForAdminService;
        public IChangeStatusForAdminService ChangeStatusForAdminService
        {
            get
            {
                return _changeStatusForAdminService ??= new ChangeStatusForAdminService(_db);
            }
        }
        

    }
}

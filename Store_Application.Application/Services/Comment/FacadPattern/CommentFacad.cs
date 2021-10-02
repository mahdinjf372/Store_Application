using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Comment.Commads.AddComment;
using Store_Application.Application.Services.Comment.Commads.DislikeComment;
using Store_Application.Application.Services.Comment.Commads.LikeComment;
using Store_Application.Application.Services.Comment.Queries.GetComments;
using Store_Application.Application.Services.Comment.Queries.IsExistComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Comment.FacadPattern
{
    public class CommentFacad : ICommentFacad
    {
        private readonly IDataBaseContext _db;
        public CommentFacad(IDataBaseContext db)
        {
            _db = db;
        }

        private IAddCommentService _addCommentService;
        public IAddCommentService AddCommentService
        {
            get
            {
                return _addCommentService = _addCommentService ?? new AddCommentService(_db);
            }
        }

        private IGetCommentsService _getCommentsService;
        public IGetCommentsService GetCommentsService
        {
            get
            {
                return _getCommentsService = _getCommentsService ?? new GetCommentsService(_db);
            }
        }

        private ILikeCommentService _likeCommentService;
        public ILikeCommentService LikeCommentService
        {
            get
            {
                return _likeCommentService = _likeCommentService ?? new LikeCommentService(_db);
            }
        }

        private IDislikeCommentService _dislikeCommentService;
        public IDislikeCommentService DislikeCommentService
        {
            get
            {
                return _dislikeCommentService = _dislikeCommentService ?? new DislikeCommentService(_db);
            }
        }

        private IisExistCommentService _isExistCommentService;
        public IisExistCommentService IsExistCommentService
        {
            get
            {
                return _isExistCommentService = _isExistCommentService ?? new IsExistCommentService(_db);
            }
        }


    }
}

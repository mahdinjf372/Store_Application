using AutoMapper;
using EndPoint.WebSite.Models.Comment.Add;
using EndPoint.WebSite.Models.Comment.DislikeComment;
using EndPoint.WebSite.Models.Comment.LikeComment;
using EndPoint.WebSite.Models.Comment.LoadComments;
using EndPoint.WebSite.Utilities;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Services.Comment.Commads.AddComment;
using Store_Application.Application.Services.Comment.Commads.DislikeComment;
using Store_Application.Application.Services.Comment.Commads.LikeComment;
using Store_Application.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentFacad _commentFacad;
        private readonly IProductFacad _productFacad;
        private readonly ClaimUtility _claimUtility;
        private readonly IMapper _mapper;

        public CommentController(ICommentFacad commentFacad,
            IProductFacad productFacad,
            ClaimUtility claimUtility,
            IMapper mapper)
        {
            _commentFacad = commentFacad;
            _productFacad = productFacad;
            _claimUtility = claimUtility;
            _mapper = mapper;
        }

        [HttpPost]
        public PartialViewResult LoadComments(int productId, int page, int take)
        {
            var res = _commentFacad.GetCommentsService.Execute(productId, page, take);

            var model = new List<LoadCommentsViewModel>();

            if (res.IsSuccess)
            {
                model = _mapper.Map<List<LoadCommentsViewModel>>(res.Data).OrderBy(q => q.InsertTime).ToList();

            }
            ViewBag.ProductId = productId;
            return PartialView("/Views/Comment/_LoadComments.cshtml", model);
        }

        [HttpPost]
        public IActionResult Add(AddCommentViewModel req)
        {
            var RequestValidation = new AddCommentViewModelValidator(_productFacad);
            var Validation = RequestValidation.Validate(req);
            Validation.AddToModelState(ModelState, null);

            ResultDto res = new ResultDto();

            if (!ModelState.IsValid)
            {
                res.Message = ModelState.Values.Single(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                    .Errors.First().ErrorMessage;
                res.IsSuccess = false;
                return Json(res);
            }

            var serviceRequest = _mapper.Map<RequestAddCommentDto>(req);
            serviceRequest.UserId = _claimUtility.GetUserId(User);

            res = _commentFacad.AddCommentService.Execute(serviceRequest);

            return Json(res);
        }

        [HttpPost]
        public IActionResult LikeComment(LikeCommentViewModel req)
        {
            var RequestValidation = new LikeCommentViewModelValidator(_productFacad, _commentFacad);
            var Validation = RequestValidation.Validate(req);
            Validation.AddToModelState(ModelState, null);

            ResultDto<ResultLikeCommentDto> res = new ResultDto<ResultLikeCommentDto>();

            if (!ModelState.IsValid)
            {
                res.Message = ModelState.Values.Single(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                    .Errors.First().ErrorMessage;
                res.IsSuccess = false;
                return Json(res);
            }

            res = _commentFacad.LikeCommentService.Execute(new RequestLikeCommentDto
            {
                CommentId = req.CommentId,
                UserId = _claimUtility.GetUserId(User)
            });

            return Json(res);
        }

        [HttpPost]
        public IActionResult DislikeComment(DislikeCommentViewModel req)
        {
            var RequestValidation = new DislikeCommentViewModelValidator(_productFacad, _commentFacad);
            var Validation = RequestValidation.Validate(req);
            Validation.AddToModelState(ModelState, null);

            ResultDto<ResultDislikeCommentDto> res = new ResultDto<ResultDislikeCommentDto>();

            if (!ModelState.IsValid)
            {
                res.Message = ModelState.Values.Single(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                    .Errors.First().ErrorMessage;
                res.IsSuccess = false;
                return Json(res);
            }

            res = _commentFacad.DislikeCommentService.Execute(new RequestDislikeCommentDto
            {
                CommentId = req.CommentId,
                UserId = _claimUtility.GetUserId(User)
            });

            return Json(res);
        }
    }
}

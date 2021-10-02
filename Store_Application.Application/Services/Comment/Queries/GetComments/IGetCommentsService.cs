﻿using Store_Application.Common.ViewModels;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application.Services.Comment.Queries.GetComments
{
    public interface IGetCommentsService
    {
        ResultDto<List<ResultGetCommentsDto>> Execute(int productId,int page,int take);
    }
}

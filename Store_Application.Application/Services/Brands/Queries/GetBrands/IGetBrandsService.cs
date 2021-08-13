using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;


namespace Store_Application.Application.Services.Brands.Queries.GetBrands
{
    public interface IGetBrandsService
    {
        ResultDto<List<ResultGetBrandsDto>> Execute();
    }
}

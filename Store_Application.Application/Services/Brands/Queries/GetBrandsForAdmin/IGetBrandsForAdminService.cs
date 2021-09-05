using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Common.ViewModels;


namespace Store_Application.Application.Services.Brands.Queries.GetBrandsForAdmin
{
    public interface IGetBrandsForAdminService
    {
        ResultDto<List<ResultGetBrandsForAdminDto>> Execute(bool IgnoreFilters = false);
    }
}

using EndPoint.WebSite.Areas.UserPanel.Models.Components;
using Microsoft.AspNetCore.Mvc;
using Store_Application.Application.Interfaces.FacadPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.UserPanel.ViewComponents
{
    public class ProfileBoxViewComponent : ViewComponent
    {
        private readonly IUserFacad _userFacad;
        public ProfileBoxViewComponent(IUserFacad userFacad)
        {
            _userFacad = userFacad;
        }

        public async Task<IViewComponentResult> InvokeAsync(int userId)
        {
            var res = _userFacad.GetUserByIdForUserPanelService.Execute(userId);
            ProfileBoxViewModel model = new ProfileBoxViewModel()
            {
                FullName = res.Data.FullName,
                UserName = res.Data.Username,
                IsActive = res.Data.IsActive,
            };
            return View("ProfileBox",model);
        }

    }
}

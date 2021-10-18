using AutoMapper;
using EndPoint.WebSite.Areas.UserPanel.Models.Account.Index;
using Store_Application.Application.Services.Users.Queries.GetUserByIdForUserPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Mapper.UserPanel
{
    public class AccountControllerMappers : Profile
    {
        public AccountControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<ResultGetUserByIdForUserPanelDto, UserPanelViewModel>();

        }
    }
}

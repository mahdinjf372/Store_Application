using AutoMapper;
using EndPoint.WebSite.Areas.Admin;
using EndPoint.WebSite.Areas.Admin.Models.Common;
using EndPoint.WebSite.Areas.Admin.Models.Users.EditUser;
using EndPoint.WebSite.Areas.Admin.Models.Users.LoadUsers;
using EndPoint.WebSite.Areas.Admin.Models.Users.RegisterUser;
using Store_Application.Application.Services.Users.Commands.EditUserForAdmin;
using Store_Application.Application.Services.Users.Commands.RegisterUserForAdmin;
using Store_Application.Application.Services.Users.Queries.GetUserByIdForAdmin;
using Store_Application.Application.Services.Users.Queries.GetUsersForAdmin;
using System.Collections.Generic;

namespace EndPoint.WebSite.Mapper.Admin
{
    public class UsersControllerMappers : Profile
    {
        public UsersControllerMappers()
        {
            AllowNullCollections = true;
            CreateMap<ResultGetUsersForAdminDto, LoadUsersViewModel>();
            CreateMap<GetUsersForAdminDto, UserViewModel>();
            CreateMap<ResultGetUsersForAdminDto, PagingViewModel>()
                .ForMember(outer => outer.CurrentPage, opt => opt.MapFrom(inner => inner.CurrentPage))
                .ForMember(outer => outer.PageCount, opt => opt.MapFrom(inner => inner.PageCount));

            CreateMap<RegisterUserViewModel, RequestRegisterUserForAdminDto>();
            CreateMap<int, RegisterRoleDto>()
                .ForMember(outer => outer.Id, opt => opt.MapFrom(inner => inner));

            CreateMap<EditUserViewModel, RequestEditUserForAdminDto>();
            CreateMap<int, EditRoleDto>()
                .ForMember(outer => outer.Id, opt => opt.MapFrom(inner => inner));


        }
    }
}

using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Extentions;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;

namespace Store_Application.Application.Services.Users.Queries.GetUserByIdForUserPanel
{
    public class GetUserByIdForUserPanelService : IGetUserByIdForUserPanelService
    {
        private readonly IDataBaseContext _db;
        public GetUserByIdForUserPanelService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<ResultGetUserByIdForUserPanelDto> Execute(int id)
        {
            User _user = _db.Users.Find(id);

            ResultGetUserByIdForUserPanelDto user = new ResultGetUserByIdForUserPanelDto()
            {
                Address = _user.Address,
                age = _user.age,
                Email = _user.Email,
                FullName = _user.FullName,
                Id = _user.Id,
                Phone = _user.Phone,
                Username = _user.Username,
                RegisterDate = _user.InsertTime.ToShamsi(),
                IsActive = _user.isActive
            };

            return new ResultDto<ResultGetUserByIdForUserPanelDto>()
            {
                Data = user,
                IsSuccess = true,
                Message = "كاربر با موفقيت يافت و واكشي شد"
            };
        }
    }

}

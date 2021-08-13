using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;

namespace Store_Application.Application.Services.Users.Queries.GetUserById
{
    public class GetUserByIdService : IGetUserByIdService
    {
        private readonly IDataBaseContext _db;
        public GetUserByIdService(IDataBaseContext db)
        {
            _db = db;
        }
        public ResultDto<ResultGetUserByIdDto> Execute(int id)
        {
            User _user = _db.Users.Find(id);

            ResultGetUserByIdDto user = new ResultGetUserByIdDto()
            {
                Address = _user.Address,
                age = _user.age,
                Email = _user.Email,
                FullName = _user.FullName,
                Id = _user.Id,
                Phone = _user.Phone,
                RoleId = _user.RoleId,
                Username = _user.Username
            };

            return new ResultDto<ResultGetUserByIdDto>()
            {
                Data = user,
                IsSuccess = true,
                Message = "كاربر با موفقيت يافت و واكشي شد"
            };
        }
    }

}

using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Senders.Email.ActivationCode;
using Store_Application.Common.Security;
using Store_Application.Common.ViewModels;
using Store_Application.Domain.Entities.User;
using System;

namespace Store_Application.Application.Services.Users.Commands.RegisterUserForAdmin
{
    public class RegisterUserForAdminService : IRegisterUserForAdminService
    {
        private readonly IDataBaseContext _db;
        private ISendActivationLinkEmailService _sendActivationLinkEmailService;

        public RegisterUserForAdminService(IDataBaseContext db, ISendActivationLinkEmailService sendActivationLinkEmailService)
        {
            _db = db;
            _sendActivationLinkEmailService = sendActivationLinkEmailService;
        }
        public ResultDto Execute(RequestRegisterUserForAdminDto req)
        {
            int err = 0;
            try
            {
                var user = new User()
                {
                    ActiveCode = Guid.NewGuid().ToString(),
                    Email = req.Email,
                    InsertTime = DateTime.Now,
                    isActive = false,
                    Password = PasswordHelper.HashPassword(req.Password),
                    RoleId = req.RoleId,
                    Username = req.Username
                };

                _db.Users.Add(user);

                err = _db.SaveChanges();

                _sendActivationLinkEmailService.Execute(user.Email,user.ActiveCode,user.Username);

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "کاربر جدید با موفقیت ایجاد شد"
                };
            }
            catch (Exception e)
            {
                if (e.InnerException != null && e.InnerException.Message.Contains("Cannot insert duplicate key row in object 'dbo.Users' with unique index 'IX_Users_Email'."))
                {
                    return new ResultDto()
                    {
                        IsSuccess = false,
                        Message = "این ایمیل قبلا ثبت شده است"
                    };
                }

                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "ثبت نام نام شما با شکست مواجه شد!"
                };

            }

        }
    }
}

using EndPoint.WebSite.Areas.Admin.Models.Category.AddSubCategory;
using EndPoint.WebSite.Areas.Admin.Models.Category.CreateCategory;
using EndPoint.WebSite.Areas.Admin.Models.Category.EditCategory;
using EndPoint.WebSite.Areas.Admin.Models.Product.Create;
using EndPoint.WebSite.Areas.Admin.Models.Product.Edit;
using EndPoint.WebSite.Areas.Admin.Models.Users.EditUser;
using EndPoint.WebSite.Areas.Admin.Models.Users.RegisterUser;
using EndPoint.WebSite.Models.Authentication.Login;
using EndPoint.WebSite.Models.Authentication.PasswordForget;
using EndPoint.WebSite.Models.Authentication.PasswordRecovery;
using EndPoint.WebSite.Models.Authentication.Register;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.DependencyInjection
{
    public static class ValidationDI
    {
        public static void ConfigureAdminValidationServices(this IServiceCollection services)
        {
            services.AddTransient<IValidator<RegisterUserViewModel>, RegisterUserViewModelValidator>();
            services.AddTransient<IValidator<RegisterViewModel>, RegisterViewModelValidator>();
            services.AddTransient<IValidator<LoginViewModel>, LoginViewModelValidator>();
            services.AddTransient<IValidator<PasswordForgetViewModel>, PasswordForgetViewModelValidator>();
            services.AddTransient<IValidator<RecoveryPasswordViewModel>, RecoveryPasswordViewModelValidator>();
            services.AddTransient<IValidator<EditUserViewModel>, EditUserViewModelValidator>();
            services.AddTransient<IValidator<AddSubCategoryViewModel>, AddSubCategoryViewModelValidator>();
            services.AddTransient<IValidator<CreateCategoryViewModel>, CreateCategoryViewModelValidator>();
            services.AddTransient<IValidator<EditCategoryViewModel>, EditCategoryViewModelValidator>();
            services.AddTransient<IValidator<CreateProductViewModel>, CreateProductViewModelValidator>();
            services.AddTransient<IValidator<EditProductViewModel>, EditProductViewModelValidator>();
        }
    }
}

using EndPoint.WebSite.Areas.UserPanel.Models.Account.ChangePassword;
using EndPoint.WebSite.Areas.UserPanel.Models.Account.EditAccountInformation;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.UserPanel.Models.DependencyInjection
{
    public static class ValidationDI
    {
        public static void ConfigureUserPanelValidationServices(this IServiceCollection services)
        {
            services.AddTransient<IValidator<EditAccountInformationViewModel>, EditAccountInformationViewModelValidator>();
            services.AddTransient<IValidator<ChangePasswordViewModel>, ChangePasswordViewModelValidator>();

        }
    }
}

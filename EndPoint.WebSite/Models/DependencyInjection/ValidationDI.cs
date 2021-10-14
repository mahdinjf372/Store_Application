using EndPoint.WebSite.Models.Checkout.Index;
using EndPoint.WebSite.Models.Question.Add;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EndPoint.WebSite.Models.DependencyInjection
{
    public static class ValidationDI
    {
        public static void ConfigureSiteValidationServices(this IServiceCollection services)
        {
            services.AddTransient<IValidator<CheckoutViewModel>, CheckoutViewModelValidator>();
            services.AddTransient<IValidator<AddQuestionViewModel>, AddQuestionViewModelValidator>();
        }

    }
}

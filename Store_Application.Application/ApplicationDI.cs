using Microsoft.Extensions.DependencyInjection;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Senders.Email.ActivationCode;
using Store_Application.Application.Senders.Email.ChangePassword;
using Store_Application.Application.Senders.Email.Common;
using Store_Application.Application.Services.Advertinig.FacadPattern;
using Store_Application.Application.Services.Brands.FacadPattern;
using Store_Application.Application.Services.BrandSlider.FacadPattern;
using Store_Application.Application.Services.Carts.FacadPattern;
using Store_Application.Application.Services.Categories.FacadPattern;
using Store_Application.Application.Services.Comment.FacadPattern;
using Store_Application.Application.Services.Compare.FacadPattern;
using Store_Application.Application.Services.Favorite.FacadPattern;
using Store_Application.Application.Services.Features.FacadPattern;
using Store_Application.Application.Services.MainSlider.FacadPattern;
using Store_Application.Application.Services.Orders.FacadPattern;
using Store_Application.Application.Services.ProductFeatures.FacadPattern;
using Store_Application.Application.Services.Products.FacadPattern;
using Store_Application.Application.Services.ProductSliders.FacadPattern;
using Store_Application.Application.Services.Question.FacadPattern;
using Store_Application.Application.Services.RequestPay.FacadPattern;
using Store_Application.Application.Services.SearchKeyInfo.FacadPattern;
using Store_Application.Application.Services.SiteRequest.FacadPattern;
using Store_Application.Application.Services.Sliders.FacadPattern;
using Store_Application.Application.Services.Users.FacadPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Application
{
    public static class ApplicationDI
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ISendEmailService, SendEmailService>();
            services.AddScoped<ISendChangePasswordLinkService, SendChangePasswordLinkService>();
            services.AddScoped<ISendActivationLinkEmailService, SendActivationLinkEmailService>();

            services.AddScoped<IUserFacad, UserFacad>();
            services.AddScoped<ICategoryFacad, CategoryFacad>();
            services.AddScoped<IFeatureFacad, FeatureFacad>();
            services.AddScoped<IProductFacad, ProductFacad>();
            services.AddScoped<IBrandFacad, BrandFacad>();
            services.AddScoped<IProductFeaturesFacad, ProductFeaturesFacad>();
            services.AddScoped<ISlidersFacad, SlidersFacad>();
            services.AddScoped<IProductSlidersFacad, ProductSlidersFacad>();
            services.AddScoped<IMainSliderFacad, MainSliderFacad>();
            services.AddScoped<IBrandSliderFacad, BrandSliderFacad>();
            services.AddScoped<IAdvertisingFacad, AdvertisingFacad>();
            services.AddScoped<ICartFacad, CartFacad>();
            services.AddScoped<IOrderFacad, OrderFacad>();
            services.AddScoped<IRequestPayFacad, RequestPayFacad>();
            services.AddScoped<IQuestionFacad, QuestionFacad>();
            services.AddScoped<ICommentFacad, CommentFacad>();
            services.AddScoped<IFavoriteFacad, FavoriteFacad>();
            services.AddScoped<ICompareFacad, CompareFacad>();
            services.AddScoped<ISiteRequestFacad, SiteRequestFacad>();
            services.AddScoped<ISearchKeyInfoFacad, SearchKeyInfoFacad>();
        }
    }
}

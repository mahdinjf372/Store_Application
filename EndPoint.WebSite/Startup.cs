using EndPoint.WebSite.Areas.Admin.Models.Category.AddSubCategory;
using EndPoint.WebSite.Areas.Admin.Models.Category.CreateCategory;
using EndPoint.WebSite.Areas.Admin.Models.Category.EditCategory;
using EndPoint.WebSite.Areas.Admin.Models.Users.EditUser;
using EndPoint.WebSite.Areas.Admin.Models.Users.RegisterUser;
using EndPoint.WebSite.Models.Authentication.Login;
using EndPoint.WebSite.Models.Authentication.PasswordForget;
using EndPoint.WebSite.Models.Authentication.PasswordRecovery;
using EndPoint.WebSite.Models.Authentication.Register;
using EndPoint.WebSite.Areas.Admin.Models.Product.Create;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Application.Interfaces.FacadPattern;
using Store_Application.Application.Senders.Email.ActivationCode;
using Store_Application.Application.Senders.Email.ChangePassword;
using Store_Application.Application.Senders.Email.Common;
using Store_Application.Application.Services.Features.FacadPattern;
using Store_Application.Application.Services.Categories.FacadPattern;
using Store_Application.Application.Services.Users.FacadPattern;
using Store_Application.Application.Services.Products.FacadPattern;
using Store_Application.Application.Services.Brands.FacadPattern;
using Store_Application.Application.Services.ProductFeatures.FacadPattern;
using Store_Application.Persistence.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using Store_Application.Application.Services.Sliders.FacadPattern;
using Store_Application.Application.Services.ProductSliders.FacadPattern;
using EndPoint.WebSite.Areas.Admin.Models.Product.Edit;
using Store_Application.Application.Services.MainSlider.FacadPattern;
using Store_Application.Application.Services.BrandSlider.FacadPattern;
using Store_Application.Application.Services.Advertinig.FacadPattern;
using EndPoint.WebSite.Areas.UserPanel.Models.Account.EditAccountInformation;
using EndPoint.WebSite.Areas.UserPanel.Models.Account.ChangePassword;
using EndPoint.WebSite.Utilities;
using Store_Application.Application.Services.Carts.FacadPattern;
using Store_Application.Application.Services.Orders.FacadPattern;
using EndPoint.WebSite.Models.Checkout.Index;
using Store_Application.Application.Services.RequestPay.FacadPattern;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Store_Application.Application.Services.Question.FacadPattern;
using EndPoint.WebSite.Models.Question.Add;
using Store_Application.Application.Services.Comment.FacadPattern;
using Store_Application.Application.Services.Compare.FacadPattern;
using Store_Application.Application.Services.Favorite.FacadPattern;

namespace EndPoint.WebSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region IoC

            services.AddScoped<IDataBaseContext, DataBaseContext>();
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
            services.AddScoped<CookiesManager, CookiesManager>();
            services.AddScoped<ClaimUtility, ClaimUtility>();
            services.AddScoped<IQuestionFacad, QuestionFacad>();
            services.AddScoped<ICommentFacad, CommentFacad>();
            services.AddScoped<IFavoriteFacad, FavoriteFacad>();
            services.AddScoped<ICompareFacad, CompareFacad>();

            #endregion

            #region validation services
            //admin
            services.AddTransient<IValidator<RegisterUserViewModel>, RegisterUserViewModelValidator>();
            services.AddTransient<IValidator<RegisterViewModel>, RegisterViewModelValidator>();
            services.AddTransient<IValidator<LoginViewModel>, LoginViewModelValidator>();
            services.AddTransient<IValidator<PasswordForgetViewModel>, PasswordForgetViewModelValidator>();
            services.AddTransient<IValidator<RecoveryPasswordViewModel>, RecoveryPasswordViewModelValidator>();
            services.AddTransient<IValidator<EditUserViewModel>, EditUserViewModelValidator>();
            services.AddTransient<IValidator<RegisterUserViewModel>, RegisterUserViewModelValidator>();
            services.AddTransient<IValidator<AddSubCategoryViewModel>, AddSubCategoryViewModelValidator>();
            services.AddTransient<IValidator<CreateCategoryViewModel>, CreateCategoryViewModelValidator>();
            services.AddTransient<IValidator<EditCategoryViewModel>, EditCategoryViewModelValidator>();
            services.AddTransient<IValidator<CreateProductViewModel>, CreateProductViewModelValidator>();
            services.AddTransient<IValidator<EditProductViewModel>, EditProductViewModelValidator>();

            //userPanel
            services.AddTransient<IValidator<EditAccountInformationViewModel>, EditAccountInformationViewModelValidator>();
            services.AddTransient<IValidator<ChangePasswordViewModel>, ChangePasswordViewModelValidator>();

            //site
            
            services.AddTransient<IValidator<CheckoutViewModel>, CheckoutViewModelValidator>();
            services.AddTransient<IValidator<AddQuestionViewModel>, AddQuestionViewModelValidator>();


            #endregion

            #region Add Authentication

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(option =>
            {
                option.LoginPath = "/Login";
                option.LogoutPath = "/LogOut";
                option.AccessDeniedPath = "/AccessDenied";
                option.ExpireTimeSpan = TimeSpan.FromDays(30);
            });

            #endregion

            #region Encoder

            services.AddSingleton<HtmlEncoder>(
                HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.BasicLatin,
                    UnicodeRanges.Arabic }));

            #endregion

            //string connection = "Data Source=.;Initial Catalog=StoreApplication_DB;Integrated Security=True;";
            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddControllersWithViews().AddFluentValidation();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.Use(async (ctx, next) =>
            {
                await next();
                if (ctx.Response.StatusCode == 404 && !ctx.Response.HasStarted)
                {
                    ctx.Response.Redirect("/NotFound");
                    return;
                }
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Users}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

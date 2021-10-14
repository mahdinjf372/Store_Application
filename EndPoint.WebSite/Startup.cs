using EndPoint.WebSite.Areas.Admin.Models.DependencyInjection;
using EndPoint.WebSite.Areas.UserPanel.Models.DependencyInjection;
using EndPoint.WebSite.Configures;
using EndPoint.WebSite.Middlewares;
using EndPoint.WebSite.Models.DependencyInjection;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Store_Application.Application;
using Store_Application.Persistence;
using Store_Application.Persistence.Contexts;
using System;
using System.Text.Encodings.Web;
using System.Text.Unicode;

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

            services.ConfigureApplicationServices();
            services.ConfigurePersistenceServices();
            services.ConfigureWebSiteServices();
            
            //Validations
            services.ConfigureAdminValidationServices();
            services.ConfigureUserPanelValidationServices();
            services.ConfigureSiteValidationServices();

            //autoMapper
            services.AddAutoMapper(typeof(Startup));
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

            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddControllersWithViews().AddFluentValidation();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHandleStatusCodes();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseRequestCounter();
            app.UseSearchKeysCounter();

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

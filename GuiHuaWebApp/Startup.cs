using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using GuiHuaWebApp.Data;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace GuiHuaWebApp
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

            services.AddRazorPages().AddRazorRuntimeCompilation()
                .AddRazorPagesOptions(options =>
                {
                    
                    options.Conventions.AuthorizePage("/Home/Privacy");
                });

            services.AddControllersWithViews();

            services.AddDbContext<GuiHuaWebAppContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("GuiHuaWebAppContext")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<GuiHuaWebAppContext>();

            services.AddPaging(options => {
                options.ViewName = "Bootstrap4";
                options.PageParameterName = "pageindex";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // app.UseCookiePolicy();

            app.UseRouting();
            // app.UseRequestLocalization();
            // app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();
            // app.UseSession();
            // app.UseResponseCaching();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=GuiHuaJianDus}/{action=Index}/{id?}");
            });
        }

        public void mIdentityOption(IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                // Default SignIn settings.
                options.SignIn.RequireConfirmedEmail = false;//需要确认电子邮件登录。
                options.SignIn.RequireConfirmedPhoneNumber = false;//需要确认电话号码才能登录
                //password setting;密码设置
                options.Password.RequireDigit = true;//要求有数字
                options.Password.RequireLowercase = true;//要求小写字母
                options.Password.RequireUppercase = true;//要求大写字母
                options.Password.RequireNonAlphanumeric = true;//要求特殊字符,非字母数字字符
                options.Password.RequiredLength = 6;//要求密码最小长度，默认是 6 个字符
                options.Password.RequiredUniqueChars = 1;//要求至少要出现的字母数

                //Lockout setting；
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);//账户锁定时间
                options.Lockout.MaxFailedAccessAttempts = 5;//最大登录失败次数
                options.Lockout.AllowedForNewUsers = true;//是否可以锁定新用户

                //User seeting
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";//用户名允许的字符
                options.User.RequireUniqueEmail = false;//要求每个用户都有唯一的电子邮件。

            });

            services.ConfigureApplicationCookie(options =>
            {
                //cookie settings
                options.Cookie.Name = "myCookie";
                options.Cookie.HttpOnly = true;//指示是否可以通过客户端脚本访问cookie
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);//到期时间

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessSenied";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });

        }
    }
}

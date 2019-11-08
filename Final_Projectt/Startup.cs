using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Projectt.DAL;
using Final_Projectt.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Final_Projectt
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options => {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.IsEssential = true;
            });
           


            services.AddIdentity<AppUser, IdentityRole>(identityoptions => {
                identityoptions.Password.RequireDigit = true;
                identityoptions.Password.RequiredLength = 8;
                identityoptions.Password.RequireLowercase = true;
                identityoptions.Password.RequireUppercase = true;
                identityoptions.Password.RequireNonAlphanumeric = false;

                identityoptions.User.RequireUniqueEmail = true;

                identityoptions.Lockout.AllowedForNewUsers = true;
                identityoptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMilliseconds(30);
                identityoptions.Lockout.MaxFailedAccessAttempts = 3;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultUI()
            .AddDefaultTokenProviders();

            services.AddMvc();
            services.AddDbContext<AppDbContext>(options=> {
                options.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (!env.IsDevelopment())
            {  
                app.UseDeveloperExceptionPage();
            }
            else
            {
               app.UseExceptionHandler("/Error/Index");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Account}/{action=Login}/{id?}"
                );
            });

            app.UseMvc(routes => {
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}

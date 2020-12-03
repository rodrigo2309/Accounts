using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AccountWebMVC.Services;
using Microsoft.EntityFrameworkCore;
using AccountWebMVC.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace AccountWebMVC
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<AccountWebMVCContext>(options =>
                    options.UseMySql(Configuration.GetConnectionString("AccountWebMVCContext")));

            services.AddScoped<ReleasesService>();
            services.AddScoped<LocalService>();
            services.AddScoped<TipoService>();
            services.AddScoped<ReleasesRecordService>();
            services.AddScoped<LoginService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ReleasesService releasesService) //,LocalService localService
        {
            var enUS = new CultureInfo("en-US");
            var localizationOptions = new RequestLocalizationOptions 
            { 
                DefaultRequestCulture = new RequestCulture(enUS),
                SupportedCultures = new List<CultureInfo> {enUS},
                SupportedUICultures = new List<CultureInfo> {enUS}
            };

            app.UseRequestLocalization(localizationOptions);



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                releasesService.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

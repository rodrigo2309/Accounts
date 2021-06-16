using System;
using AccountWebMVC.Areas.Identity.Data;
using AccountWebMVC.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AccountWebMVC.Areas.Identity.IdentityHostingStartup))]
namespace AccountWebMVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AccountWebMVCContext2>(options =>
                    options.UseMySql(
                    //options.UseSqlServer(
                        context.Configuration.GetConnectionString("AccountWebMVCContext")));
                        //context.Configuration.GetConnectionString("AccountWebMVCContext2Connection")));

                services.AddDefaultIdentity<AccountWebMVCUser>()
                    .AddEntityFrameworkStores<AccountWebMVCContext2>();
            });
        }
    }
}
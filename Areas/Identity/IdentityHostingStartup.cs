using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mvc_task1.Data;

[assembly: HostingStartup(typeof(Mvc_task1.Areas.Identity.IdentityHostingStartup))]
namespace Mvc_task1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Mvc_task1Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Mvc_task1ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<Mvc_task1Context>();
            });
        }
    }
}
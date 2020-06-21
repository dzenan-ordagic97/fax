using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UslugePrijevoza.Web.Areas.Identity.Data;
using UslugePrijevoza.Web.Models;

[assembly: HostingStartup(typeof(UslugePrijevoza.Web.Areas.Identity.IdentityHostingStartup))]
namespace UslugePrijevoza.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MojDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MojDBContextConnection")));

                services.AddIdentity<MojIdentityUser,IdentityRole<int>>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MojDBContext>()
                    .AddDefaultTokenProviders();
            });
        }
    }
}
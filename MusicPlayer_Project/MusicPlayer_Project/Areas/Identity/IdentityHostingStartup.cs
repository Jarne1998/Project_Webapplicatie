using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MusicPlayer_Project.Data;

[assembly: HostingStartup(typeof(MusicPlayer_Project.Areas.Identity.IdentityHostingStartup))]
namespace MusicPlayer_Project.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MusicPlayer_ProjectContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MusicPlayer_ProjectContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MusicPlayer_ProjectContext>();
            });
        }
    }
}
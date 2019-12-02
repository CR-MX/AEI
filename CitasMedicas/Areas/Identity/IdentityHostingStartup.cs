using System;
using CitasMedicas.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CitasMedicas.Models;

[assembly: HostingStartup(typeof(CitasMedicas.Areas.Identity.IdentityHostingStartup))]
namespace CitasMedicas.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CitasContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("CitasContextConnection")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<CitasContext>();
            });
        }
    }
}
using HS14Register.AppContext;
using HS14Register.MailServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HS14Register.Extentions
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddUIServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseLazyLoadingProxies();
                options.UseSqlServer("Server=DESKTOP-HL6R8FL\\SQLEXPRESS;Database=MVC-Register;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
                
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppDbContext>()
                    .AddDefaultTokenProviders();


            services.AddScoped<IMailService, MailService>();
            return services;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using OA_DataAccess;
using OA_Repository;
using OA_Service;

namespace OA_API
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            #region Service Injected
                services.AddScoped(typeof(IRepository< >), typeof(Repository< >));
                services.AddScoped<IProductService, ProductService>();
                services.AddScoped<IUserPostService, UserPostService>();
                services.AddScoped<IUserService, UserService>();
                services.AddScoped<IUserFollowerService, UserFollowerService>();
            #endregion
            return services;
        }
    }
}

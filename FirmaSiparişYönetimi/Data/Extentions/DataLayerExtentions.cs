using Data.Context;
using Data.Repositories.Abstractions;
using Data.Repositories.Concretes;
using Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Extentions
{
    public static class DataLayerExtentions
    {

        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config) 
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }    
    }
}

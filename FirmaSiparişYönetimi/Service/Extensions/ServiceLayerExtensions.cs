
using Microsoft.Extensions.DependencyInjection;
using Service.Services.Abstractions;
using Service.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IUrunServices, UrunServices>();
            services.AddScoped<IFirmaServices, FirmaServices>();
            services.AddAutoMapper(assembly);
            return services;
        }
    }
}

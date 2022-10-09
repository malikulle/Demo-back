using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServiceCollectionAccessor(this IServiceCollection services, IHttpContextAccessor _httpContext)
        {
            services.AddScoped<ServiceCollectionAccessor>(x => new ServiceCollectionAccessor(_httpContext));
            return services;
        }

    }
}

using ECommerce.Module.Wrapper.Abstract;
using ECommerce.Module.Wrapper.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper
{
    public static class WrapperServiceRegisteration
    {
        public static IServiceCollection AddWrapperServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ICatalogService, CatalogService>();
            services.AddScoped<IMembershipService, MembershipService>();
            services.AddScoped<IConfigurationService, ConfigurationService>();
            services.AddScoped<IAddressBookService, AddressBookService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IFormatService, FormatService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ILoggingService, LoggingService>();  
            services.AddScoped<ISalesService, SalesService>();
            return services;
        }
    }
}

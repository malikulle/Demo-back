using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Integration.HangfireIntegration
{
    public static class HangfireRegisteration
    {
        public static IServiceCollection AddIntegrationHangfire(this IServiceCollection services, IConfiguration Configuration)
        {

            services.AddHangfire(configuration => configuration.UsePostgreSqlStorage(Configuration.GetConnectionString("DbContext")));
            var storage = new PostgreSqlStorage(Configuration.GetConnectionString("DbContext"));
            JobStorage.Current = storage;
            services.AddHangfireServer();
            services.AddScoped<RecureingJob>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var recureingJob = serviceProvider.GetRequiredService<RecureingJob>();
                recureingJob.Run();
            }


            return services;
        }

    }
}

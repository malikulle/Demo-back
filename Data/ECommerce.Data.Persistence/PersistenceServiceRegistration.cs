using ECommerce.Data.Persistence.Contexts;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Framework.SharedLibary.SQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                                IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DbContext")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            DatabaseConnection.ConnectionString = configuration.GetConnectionString("DbContext");
            DatabaseType.Type = Database.PostgreSQL;
            if (DatabaseType.Type == Database.PostgreSQL)
            {
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            }
            return services;
        }
    }
}

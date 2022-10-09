using ECommerce.Data.Service.Abstract.AddressBook;
using ECommerce.Data.Service.Abstract.Cache;
using ECommerce.Data.Service.Abstract.Catalog;
using ECommerce.Data.Service.Abstract.Configration;
using ECommerce.Data.Service.Abstract.Logging;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Data.Service.Abstract.Sales;
using ECommerce.Data.Service.Concrete.AddressBook;
using ECommerce.Data.Service.Concrete.Cache;
using ECommerce.Data.Service.Concrete.Catalog;
using ECommerce.Data.Service.Concrete.Configration;
using ECommerce.Data.Service.Concrete.Logging;
using ECommerce.Data.Service.Concrete.Membership;
using ECommerce.Data.Service.Concrete.Sales;
using ECommerce.Framework.SharedLibary.Token;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service
{
    public static class DataServiceRegisteration
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddHttpContextAccessor();

            #region token

            var tokenOptions = Configuration.GetSection(key: "TokenOptions").Get<TokenOptions>();

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddCookie(cfg => cfg.SlidingExpiration = true)
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(tokenOptions.SecurityKey)),
                        ValidIssuer = tokenOptions.Issuer,
                        ValidateIssuer = true,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                    };
                });
            #endregion

            services.AddScoped<ICatagoryService, CatagoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRolePermissionService, RolePermissionService>();
            services.AddScoped<IParameterService, ParameterService>();
            services.AddScoped<ICacheService, CacheService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IExceptionLogService, ExceptionLogService>();
            services.AddScoped<IAuditLogService, AuditLogService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IJobExecutionService, JobExecutionService>();
            services.AddScoped<IProductCommentService, ProductCommentService>();
            services.AddScoped<IBasketService, BasketService>();

            return services;
        }
    }
}

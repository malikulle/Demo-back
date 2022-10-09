using ECommerce.Data.Domain.Membership;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Framework.SharedLibary.Token;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Membership
{
    public class TokenService : ITokenService
    {

        private readonly TokenOptions _options;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IRepository<User> _userRepository;
        private readonly IUserService _userService;

        public TokenService(IConfiguration configuration,IHttpContextAccessor httpContext, IRepository<User> userRepository, IUserService userService)
        {
            _options = configuration.GetSection(key: "TokenOptions").Get<TokenOptions>();
            _httpContext = httpContext;
            _userRepository = userRepository;
            _userService = userService; 
        }

        public string GenerateToken(User user)
        {
            DateTime finisDate = DateTime.Now.AddDays(10);
            var roles = _userService.GetPermissions(user.ID);
            var claims =  new List<Claim>(){
                new Claim(ECommerceClaimTypes.UserID,user.ID.ToString()),
            };

            if (roles.Any())
            {
                foreach (var role in roles)
                    claims.Add(new Claim(ECommerceClaimTypes.Role, role));
            }

            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.SecurityKey));
            var token = new JwtSecurityToken(
              issuer: _options.Issuer,
              audience: _options.Audience,
              claims: claims,
              expires: finisDate,
              notBefore: DateTime.Now,
              signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public User GetCurrentUser()
        {
            return _userRepository.Query().AsNoTracking().FirstOrDefault(op => op.ID == this.GetCurrentUserID());
        }

        public long GetCurrentUserID()
        {
            return Convert.ToInt64(_httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ECommerceClaimTypes.UserID)?.Value);
        }
    }
}

using AutoMapper;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.Abstract;
using ECommerce.Module.Wrapper.ServiceModels.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Concrete
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AuthenticationService(IUserService userService, ITokenService tokenService, IMapper mapper)
        {
            _userService = userService;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        public ServiceObjectResult<RefreshTokenModel> GetRefreshToken(long userID)
        {
            var result = new ServiceObjectResult<RefreshTokenModel>();
            try
            {
                var model = new RefreshTokenModel();
                var user = _userService.GetUser(userID);
                model.Token = _tokenService.GenerateToken(user);
                model.User = _mapper.Map<UserLoginResponse>(user);
                model.User.Token = model.Token;
                model.User.Permissions = _userService.GetPermissions(userID);
                result.SetData(model);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Membership;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : BaseController
    {
        [Authorize]
        [HttpPost("GetRefreshToken")]
        public ServiceObjectResult<RefreshTokenModel> GetRefreshToken([FromBody] WebApiObjectRequest<RefreshTokenModel> request)
        {
            var result = new ServiceObjectResult<RefreshTokenModel>();
            try
            {
                result = this.Client.Authentication.GetRefreshToken(this.Client.CurrentUserID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Abstract
{
    public interface IAuthenticationService
    {
        ServiceObjectResult<RefreshTokenModel> GetRefreshToken(long userID);
    }
}

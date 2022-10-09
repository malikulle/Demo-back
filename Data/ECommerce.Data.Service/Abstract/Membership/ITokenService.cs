using ECommerce.Data.Domain.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Membership
{
    public interface ITokenService
    {
        string GenerateToken(User user);
        long GetCurrentUserID();
        User GetCurrentUser();
    }
}

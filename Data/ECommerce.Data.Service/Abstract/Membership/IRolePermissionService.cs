using ECommerce.Data.Domain.Membership;
using ECommerce.Framework.SharedLibary.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Membership
{
    public interface IRolePermissionService
    {
        ServiceObjectResult<RolePermission> Update(RolePermission entity);
    }
}

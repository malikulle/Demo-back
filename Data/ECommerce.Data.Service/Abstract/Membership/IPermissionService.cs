using ECommerce.Data.Domain.Membership;
using ECommerce.Framework.SharedLibary.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Membership
{
    public interface IPermissionService
    {
        Permission GetPermission(long ID);   
        IQueryable<Permission> GetPermissions(Expression<Func<Permission, bool>> predicate = null);
        ServiceObjectResult<Permission> Update(Permission entity);
    }
}

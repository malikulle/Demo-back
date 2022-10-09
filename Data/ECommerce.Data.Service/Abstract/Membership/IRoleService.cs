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
    public interface IRoleService
    {
        Role GetRole(long ID);
        IQueryable<Role> GetRoles(Expression<Func<Role, bool>> predicate = null);    
        ServiceObjectResult<Role> Update(Role entity,List<long> permissions = null);
        List<long> GetPermissions(long ID);
    }
}

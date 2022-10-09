using ECommerce.Module.Wrapper.ServiceModels.Membership.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Membership.RolePermission
{
    public class RolePermissionModel
    {
        public long PermissionID { get; set; }
        public PermissionModel Permission { get; set; }
    }
}

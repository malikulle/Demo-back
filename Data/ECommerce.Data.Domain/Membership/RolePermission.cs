using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Membership
{
    [Table(nameof(RolePermission), Schema = "Membership")]
    public class RolePermission : DataEntity, IEntity
    {
        public long RoleID { get; set; }

        public virtual Role Role { get; set; }

        public long PermissionID { get; set; }

        public virtual Permission Permission { get; set; }
    }
}

using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Membership
{
    [Table(nameof(Role), Schema = "Membership")]
    public class Role : DataEntity, IEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// Permissions
        /// </summary>
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}

using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Membership
{
    [Table(nameof(Permission), Schema = "Membership")]
    public class Permission : DataEntity, IEntity
    {
        public string Name { get; set; }
    }
}

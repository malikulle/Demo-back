using ECommerce.Framework.SharedLibary.Attributes;
using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Catalog
{
    [AuditLogging(true)]
    [Table(nameof(Category), Schema = "Catalog")]
    public class Category : DataEntity, IEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Category_i18n> Category_i18n { get; set; }
    }
}

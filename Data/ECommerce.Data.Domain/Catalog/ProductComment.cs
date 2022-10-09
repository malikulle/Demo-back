using ECommerce.Data.Domain.Membership;
using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Catalog
{
    [Table(nameof(ProductComment), Schema = "Catalog")]
    public class ProductComment : DataEntity, IEntity
    {
        public string Text { get; set; }

        public long ProductID { get; set; }
        public virtual Product Product { get; set; }

        public long UserID { get; set; }
        public virtual User User { get; set; }

    }
}

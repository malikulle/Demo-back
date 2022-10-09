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
    [Table(nameof(Product), Schema = "Catalog")]
    public class Product : DataEntity, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public decimal Price { get; set; }

        public long CategoryID { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductComment> ProductComments { get; set; }

        public ICollection<Product_i18n> Product_i18n { get; set; }
    }
}

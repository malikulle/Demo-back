using ECommerce.Data.Domain.Catalog;
using ECommerce.Framework.SharedLibary.Attributes;
using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Sales
{
    [AuditLogging(true)]
    [Table(nameof(BasketItem), Schema = "Sales")]
    public class BasketItem :DataEntity,IEntity
    {
        /// <summary>
        /// Price * Quantity
        /// </summary>
        public decimal TotalPrice { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public long ProductID { get; set; }
        public virtual Product Product { get; set; }

        public long BasketID { get; set; }
        public virtual Basket Basket { get; set; }
    }
}

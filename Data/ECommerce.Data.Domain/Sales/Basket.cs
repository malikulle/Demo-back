using ECommerce.Data.Domain.Membership;
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
    [Table(nameof(Basket), Schema = "Sales")]
    public class Basket : DataEntity, IEntity
    {

        public long UserID { get; set; }
        public virtual User User { get; set; }

        /// <summary>
        /// <see cref="Domain.Enums.Sales.PaymentMethod"/>
        /// </summary>
        public byte PaymentMethod { get; set; }

        /// <summary>
        /// <see cref="Domain.Enums.Sales.BasketStatus"/>
        /// </summary>
        public byte BasketStatus { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal BasketPrice { get; set; }

        public decimal TaxPrice { get; set; }

        public decimal ShippingPrice { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; }
    }
}

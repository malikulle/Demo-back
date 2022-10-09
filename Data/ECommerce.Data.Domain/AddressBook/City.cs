using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.AddressBook
{
    [Table(nameof(City), Schema = "AddressBook")]
    public class City : DataEntity, IEntity
    {
        public string Name { get; set; }        
        public string PlateCode { get; set; }

        public long CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}

using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.AddressBook
{
    [Table(nameof(Country), Schema = "AddressBook")]
    public class Country : DataEntity, IEntity
    {
        public string Name { get; set; }
        public string CodeISO { get; set; }
        public string CodeISO3 { get; set; }
        public string PhoneCode { get; set; }

        public ICollection<City> Cities { get; set; }

    }
}

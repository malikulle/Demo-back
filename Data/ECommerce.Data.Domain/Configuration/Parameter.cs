using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Configuration
{
    [Table(nameof(Parameter), Schema = "Configuration")]
    public class Parameter : DataEntity, IEntity
    {
        public string Module { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}

using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Configuration
{
    [Table(nameof(Language), Schema = "Configuration")]
    public class Language : DataEntity, IEntity
    {

        public string Name { get; set; }

        public string CultureCode { get; set; }

        public string IsoCode { get; set; }

        [StringLength(500)]
        public string ImagePath { get; set; }
        
        [StringLength(500)]
        public string IconName { get; set; }

    }
}

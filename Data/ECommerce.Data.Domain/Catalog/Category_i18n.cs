using ECommerce.Data.Domain.Configuration;
using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Catalog
{
    [Table(nameof(Category_i18n), Schema = "Catalog")]
    public class Category_i18n : DataEntity, IEntity
    {
        public string Name { get; set; }

        public long CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public long LanguageID { get; set; }

        public virtual Language Language { get; set; }        

    }
}

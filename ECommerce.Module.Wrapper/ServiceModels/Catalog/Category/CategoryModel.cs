using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Catalog
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte StatusID { get; set; }
        public OrderBy OrderBy { get; set; }

        public List<CategoryModel_i18n> i18n { get; set; }
    }    
    public class CategoryModel_i18n
    {
        public string Name { get; set; }
        public long CategoryID { get; set; }
        public long LanguageID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Catalog.Product
{
    public class ProductModel
    {
        public long ID { get; set; }
        public byte StatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public long CategoryID { get; set; }
        public CategoryResponse Category { get; set; }

        public List<long> CategoryIDs { get; set; }
        public List<ProductModel_i18n> Product_i18n { get; set; }
    }

    public class ProductModel_i18n
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long LanguageID { get; set; }
    }
}

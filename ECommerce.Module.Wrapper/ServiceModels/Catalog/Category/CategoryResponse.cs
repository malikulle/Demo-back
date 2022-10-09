using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Catalog
{
    public class CategoryResponse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte StatusID { get; set; }
        public List<CategoryModel_i18n> Category_i18n { get; set; }
    }

    public class CategoryPaginationReponse : BasePageableModel
    {
        public List<CategoryResponse> Items { get; set; }
    }
}

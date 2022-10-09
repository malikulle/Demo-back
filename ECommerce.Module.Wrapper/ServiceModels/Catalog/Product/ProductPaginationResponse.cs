using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Catalog.Product
{
    public class ProductPaginationResponse : BasePageableModel
    {
        public List<ProductModel> Items { get; set; }
    }
}

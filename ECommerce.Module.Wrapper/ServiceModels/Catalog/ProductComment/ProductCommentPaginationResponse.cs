using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Catalog.ProductComment
{
    public class ProductCommentPaginationResponse : BasePageableModel
    {
        public List<ProductCommentModel> Items { get; set; }
    }
}

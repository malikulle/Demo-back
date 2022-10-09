using ECommerce.Data.Domain.Catalog;
using ECommerce.Framework.SharedLibary.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Catalog
{
    public interface IProductCommentService
    {
        ProductComment GetProductComment(long ID);
        IQueryable<ProductComment> GetProductComments(Expression<Func<ProductComment, bool>> predicate = null);
        ServiceObjectResult<ProductComment> Update(ProductComment entity);
    }
}

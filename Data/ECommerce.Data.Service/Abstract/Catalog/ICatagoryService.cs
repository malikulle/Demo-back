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
    public interface ICatagoryService
    {
        IQueryable<Category> GetCategories(Expression<Func<Category, bool>> predicate = null);
        Category GetCategory(long ID);
        bool IsNameExist(long ID, string name);
        ServiceObjectResult<Category> Update(Category entity, long languageID = 0);

    }
}

using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Persistence.Repository
{
    public interface IRepository<T> where T : DataEntity, IEntity
    {
        IQueryable<T> Query();
        IQueryable<T> QueryAll(Expression<Func<T, bool>> predicate = null);
        T Get(long ID);
        void Update(T entity);
        void Delete(T entity);
    }
}

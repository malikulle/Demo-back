using ECommerce.Data.Persistence.Contexts;
using ECommerce.Framework.SharedLibary.Domain.Base;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Persistence.Repository
{
    public class Repository<T> : IRepository<T>
    where T : DataEntity, IEntity
    {

        protected DbContext Context;

        public Repository(BaseDbContext context)
        {
            Context = context;
        }

        public void Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        public T Get(long ID)
        {
            return this.QueryAll(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<T> Query()
        {
            return Context.Set<T>();
        }

        public IQueryable<T> QueryAll(Expression<Func<T, bool>> predicate = null)
        {
            var list = this.Query().AsNoTracking().Where(op => op.StatusID != StatusValue.DeletedStatusID);
            if (predicate != null)
                list = list.Where(predicate);
            return list.OrderByDescending(op => op.ID);
        }

        public void Update(T entity)
        {
            if (entity.ID == 0)
                Context.Entry(entity).State = EntityState.Added;
            else
                Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }

}

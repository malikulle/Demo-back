using ECommerce.Data.Domain.Configuration;
using ECommerce.Framework.SharedLibary.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Configration
{
    public interface IJobService
    {
        Job GetJob(string name);
        Job GetJob(long ID);
        IQueryable<Job> GetJobs(Expression<Func<Job, bool>> predicate = null);
        ServiceObjectResult<Job> Update(Job entity);
    }
}

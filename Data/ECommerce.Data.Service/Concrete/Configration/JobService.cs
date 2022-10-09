using ECommerce.Data.Domain.Configuration;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Configration;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Configration
{
    public class JobService : IJobService
    {
        private readonly IRepository<Job> _repository;

        public JobService(IRepository<Job> repository)
        {
            _repository = repository;
        }

        public Job GetJob(string name)
        {
            return this.GetJobs(op => op.Name == name).FirstOrDefault();
        }

        public Job GetJob(long ID)
        {
            return this.GetJobs(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<Job> GetJobs(Expression<Func<Job, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate);
        }

        public ServiceObjectResult<Job> Update(Job entity)
        {
            var result = new ServiceObjectResult<Job>();
            try
            {
                Job persistent = null;
                if(entity.ID > 0)
                {
                    persistent = _repository.Query().Where(op => op.ID == entity.ID).FirstOrDefault();
                    persistent.DateModified = DateTime.Now;
                    persistent.StatusID = entity.StatusID;
                }
                else
                {
                    persistent = new Job();
                    persistent.DateCreated = DateTime.Now;
                    persistent.StatusID = StatusValue.ActiveStatusID;
                }
                persistent.Name = entity.Name;
                persistent.Description = entity.Description;
                _repository.Update(persistent);
                result.SetData(persistent);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

using ECommerce.Data.Domain.Configuration;
using ECommerce.Data.Domain.Enums.Configuration;
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
    public class JobExecutionService : IJobExecutionService
    {
        private readonly IRepository<JobExecution> _repository;
        private readonly IRepository<Job> _jobRepository;
        private readonly IRepository<JobExecutionDetail> _jobExecutionDetailRepository;

        public JobExecutionService(IRepository<JobExecution> repository, IRepository<Job> jobRepository, IRepository<JobExecutionDetail> jobExecutionDetailRepository)
        {
            _repository = repository;
            _jobRepository = jobRepository;
            _jobExecutionDetailRepository = jobExecutionDetailRepository;
        }


        public JobExecution GetJobExecution(long ID)
        {
            return this.GetJobExecutions(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<JobExecution> GetJobExecutions(Expression<Func<JobExecution, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate).Include(op => op.Job);
        }

        public ServiceObjectResult<JobExecution> Start(long jobID)
        {
            var result = new ServiceObjectResult<JobExecution>();
            try
            {
                var job = _jobRepository.Query().AsNoTracking().Where(op => op.ID == jobID).FirstOrDefault();
                if (job != null)
                {
                    var entity = new JobExecution()
                    {
                        JobID = job.ID,
                        StartDate = DateTime.Now,
                        JobExecutionType = JobExecutionValue.Running
                    };
                    result = this.Update(entity);
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<JobExecution> Finish(long jobID)
        {
            var result = new ServiceObjectResult<JobExecution>();
            try
            {
                var entity = this.GetJobExecutions(op => op.JobID == jobID && op.JobExecutionType == JobExecutionValue.Running).FirstOrDefault();
                if (entity != null)
                {
                    entity.EndDate = DateTime.Now;
                    entity.JobExecutionType = JobExecutionValue.Done;
                    result = this.Update(entity);
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<JobExecution> Update(JobExecution entity)
        {
            var result = new ServiceObjectResult<JobExecution>();
            try
            {
                JobExecution persistent = null;
                if (entity.ID > 0)
                {
                    persistent = _repository.Query().Where(op => op.ID == entity.ID).FirstOrDefault();
                    persistent.DateModified = DateTime.Now;
                    persistent.StatusID = entity.StatusID;
                }
                else
                {
                    persistent = new JobExecution();
                    persistent.DateCreated = DateTime.Now;
                    persistent.StatusID = StatusValue.ActiveStatusID;
                }
                persistent.JobID = entity.JobID;
                persistent.JobExecutionType = entity.JobExecutionType;
                persistent.StartDate = entity.StartDate;
                persistent.EndDate = entity.EndDate;
                _repository.Update(persistent);
                result.SetData(persistent);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public void WriteLog(long executionID, string description)
        {
            var entity = new JobExecutionDetail()
            {
                JobExecutionID = executionID,
                Description = description,
                StatusID = StatusValue.ActiveStatusID,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            };
            _jobExecutionDetailRepository.Update(entity);
        }

        public List<JobExecutionDetail> GetLogs(long executionID)
        {
            return _jobExecutionDetailRepository.Query().Where(op => op.StatusID != StatusValue.DeletedStatusID).AsNoTracking().Where(op => op.JobExecutionID == executionID).OrderBy(op => op.ID).ToList();
        }
    }
}

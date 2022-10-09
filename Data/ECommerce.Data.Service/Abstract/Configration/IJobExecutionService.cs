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
    public interface IJobExecutionService
    {
        JobExecution GetJobExecution(long ID);
        IQueryable<JobExecution> GetJobExecutions(Expression<Func<JobExecution, bool>> predicate = null);
        ServiceObjectResult<JobExecution> Update(JobExecution entity);
        ServiceObjectResult<JobExecution> Start(long jobID);
        ServiceObjectResult<JobExecution> Finish(long jobID);
        void WriteLog(long executionID, string description);
        List<JobExecutionDetail> GetLogs(long executionID);

    }
}

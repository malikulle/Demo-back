using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Job;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.JobExecution;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Language;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Parameter;
using ECommerce.Module.Wrapper.ServiceModels.Membership.Permission;
using ECommerce.Module.Wrapper.ServiceModels.Membership.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Abstract
{
    public interface IConfigurationService
    {
        ServiceObjectResult<LanguageModel> UpdateLanguage(LanguageModel model);
        ServiceObjectResult<LanguagePaginationResponse> GetLanguages(LanguageModel model, Dynamic dynamic);
        ServiceObjectResult<ParameterModel> GetParameter(long ID);
        ServiceObjectResult<ParameterPaginationResponse> GetParameters(ParameterModel filter, Dynamic dynamic);
        ServiceObjectResult<ParameterModel> UpdateParameter(ParameterModel model);
        ServiceObjectResult<JobModel> GetJob(long ID);
        ServiceObjectResult<JobPaginationResponse> GetJobs(JobModel filter, Dynamic dynamic);   
        ServiceObjectResult<JobModel> UpdateJob(JobModel model);
        ServiceObjectResult<JobExecutionModel> GetJobExecution(long ID);
        ServiceObjectResult<JobExecutionPaginationResponse> GetJobExecutions(JobExecutionModel filter, Dynamic dynamic);
    }
}

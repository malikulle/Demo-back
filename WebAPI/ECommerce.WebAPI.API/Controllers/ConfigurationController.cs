using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Job;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.JobExecution;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Language;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Parameter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : BaseController
    {

        [HttpPost("GetLanguages")]
        public ServiceObjectResult<LanguagePaginationResponse> GetLanguages([FromBody] WebAPICollectionRequest<LanguageModel> request)
        {
            var result = new ServiceObjectResult<LanguagePaginationResponse>();
            try
            {
                result = this.Client.Configuration.GetLanguages(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateParameter")]
        [HttpPost("GetParameter")]
        public ServiceObjectResult<ParameterModel> GetParameter([FromBody] WebApiObjectRequest<ParameterModel> request)
        {
            var result = new ServiceObjectResult<ParameterModel>();
            try
            {
                result = this.Client.Configuration.GetParameter(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,ParameterList")]
        [HttpPost("GetParameters")]
        public ServiceObjectResult<ParameterPaginationResponse> GetParameters([FromBody] WebAPICollectionRequest<ParameterModel> request)
        {
            var result = new ServiceObjectResult<ParameterPaginationResponse>();
            try
            {
                result = this.Client.Configuration.GetParameters(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateParameter")]
        [HttpPost("UpdateParameter")]
        public ServiceObjectResult<ParameterModel> UpdateParameter([FromBody] WebApiObjectRequest<ParameterModel> request)
        {
            var result = new ServiceObjectResult<ParameterModel>();
            try
            {
                result = this.Client.Configuration.UpdateParameter(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateJob")]
        [HttpPost("GetJob")]
        public ServiceObjectResult<JobModel> GetJob([FromBody] WebApiObjectRequest<JobModel> request)
        {
            var result = new ServiceObjectResult<JobModel>();
            try
            {
                result = this.Client.Configuration.GetJob(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,JobList")]
        [HttpPost("GetJobs")]
        public ServiceObjectResult<JobPaginationResponse> GetJobs([FromBody] WebAPICollectionRequest<JobModel> request)
        {
            var result = new ServiceObjectResult<JobPaginationResponse>();
            try
            {
                result = this.Client.Configuration.GetJobs(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateJob")]
        [HttpPost("UpdateJob")]
        public ServiceObjectResult<JobModel> UpdateJob([FromBody] WebApiObjectRequest<JobModel> request)
        {
            var result = new ServiceObjectResult<JobModel>();
            try
            {
                result = this.Client.Configuration.UpdateJob(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,JobExecutionList")]
        [HttpPost("GetJobExecution")]
        public ServiceObjectResult<JobExecutionModel> GetJobExecution([FromBody] WebApiObjectRequest<JobExecutionModel> request)
        {
            var result = new ServiceObjectResult<JobExecutionModel>();
            try
            {
                result = this.Client.Configuration.GetJobExecution(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,JobExecutionList")]
        [HttpPost("GetJobExecutions")]
        public ServiceObjectResult<JobExecutionPaginationResponse> GetJobExecutions([FromBody] WebAPICollectionRequest<JobExecutionModel> request)
        {
            var result = new ServiceObjectResult<JobExecutionPaginationResponse>();
            try
            {
                result = this.Client.Configuration.GetJobExecutions(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }


}

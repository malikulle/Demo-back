using AutoMapper;
using ECommerce.Data.Domain.Configuration;
using ECommerce.Data.Domain.Membership;
using ECommerce.Data.Service.Abstract.Cache;
using ECommerce.Data.Service.Abstract.Configration;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Paging;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.Abstract;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Job;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.JobExecution;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Language;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Parameter;

namespace ECommerce.Module.Wrapper.Concrete
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly ILanguageService _languageService;
        private readonly ICacheService _cacheService;
        private readonly IParameterService _parameterService;
        private readonly IJobService _jobService;
        private readonly IJobExecutionService _jobExecutionService;
        private readonly IMapper _mapper;

        public ConfigurationService(IMapper mapper, ILanguageService languageService, ICacheService cacheService, IParameterService parameterService, IJobService jobService, IJobExecutionService jobExecutionService)
        {
            _mapper = mapper;
            _languageService = languageService;
            _cacheService = cacheService;
            _parameterService = parameterService;
            _jobService = jobService;
            _jobExecutionService = jobExecutionService;
        }

        public ServiceObjectResult<JobModel> GetJob(long ID)
        {
            var result = new ServiceObjectResult<JobModel>();
            try
            {
                var entiy = _jobService.GetJob(ID);
                var mappedEntity = _mapper.Map<JobModel>(entiy);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<JobExecutionModel> GetJobExecution(long ID)
        {
            var result = new ServiceObjectResult<JobExecutionModel>();
            try
            {
                var entiy = _jobExecutionService.GetJobExecution(ID);
                var mappedEntity = _mapper.Map<JobExecutionModel>(entiy);
                result.SetData(mappedEntity);
                if(result.Data != null)                
                    result.Data.Logs = _mapper.Map<List<JobExecutionDetailModel>>(_jobExecutionService.GetLogs(ID));
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<JobExecutionPaginationResponse> GetJobExecutions(JobExecutionModel filter, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<JobExecutionPaginationResponse>();
            try
            {
                var list = _jobExecutionService.GetJobExecutions().AsQueryable();
                var mappedList = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<JobExecutionPaginationResponse>(mappedList);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<JobPaginationResponse> GetJobs(JobModel filter, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<JobPaginationResponse>();
            try
            {
                var list = _jobService.GetJobs().AsQueryable();
                var mappedList = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<JobPaginationResponse>(mappedList);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<LanguagePaginationResponse> GetLanguages(LanguageModel model, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<LanguagePaginationResponse>();
            try
            {
                var list = _cacheService.GetLanguages().AsQueryable();
                var mappedList = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<LanguagePaginationResponse>(mappedList);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ParameterModel> GetParameter(long ID)
        {
            var result = new ServiceObjectResult<ParameterModel>();
            try
            {
                var entiy = _parameterService.GetParameter(ID);
                var mappedEntity = _mapper.Map<ParameterModel>(entiy);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ParameterPaginationResponse> GetParameters(ParameterModel filter, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<ParameterPaginationResponse>();
            try
            {
                var list = _parameterService.GetParameters().AsQueryable();
                var paginatedList = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<ParameterPaginationResponse>(paginatedList);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<JobModel> UpdateJob(JobModel model)
        {
            var result = new ServiceObjectResult<JobModel>();
            try
            {
                var entity = _mapper.Map<Job>(model);
                var updateResult = _jobService.Update(entity);
                if (updateResult.HasFailed)
                {
                    result.Fail(updateResult);
                    return result;
                }

                var mappedEntity = _mapper.Map<JobModel>(updateResult.Data);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<LanguageModel> UpdateLanguage(LanguageModel model)
        {
            var result = new ServiceObjectResult<LanguageModel>();
            try
            {
                var entity = _mapper.Map<Language>(model);
                var updateResult = _languageService.Update(entity);
                if (updateResult.HasFailed)
                {
                    result.Fail(updateResult);
                    return result;
                }

                var mappedEntity = _mapper.Map<LanguageModel>(updateResult.Data);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ParameterModel> UpdateParameter(ParameterModel model)
        {
            var result = new ServiceObjectResult<ParameterModel>();
            try
            {
                var entity = _mapper.Map<Parameter>(model);
                var updateResult = _parameterService.Update(entity);
                if (updateResult.HasFailed)
                {
                    result.Fail(updateResult);
                    return result;
                }
                var mappedEnttiy = _mapper.Map<ParameterModel>(updateResult.Data);
                result.SetData(mappedEnttiy);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

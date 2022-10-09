using AutoMapper;
using ECommerce.Data.Service.Abstract.Logging;
using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Paging;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.Abstract;
using ECommerce.Module.Wrapper.ServiceModels.Logging.AuiditLog;
using ECommerce.Module.Wrapper.ServiceModels.Logging.ExceptionLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Concrete
{
    public class LoggingService : ILoggingService
    {
        private readonly IExceptionLogService _exceptionLogService;
        private readonly IAuditLogService _auditLogService;
        private readonly IMapper _mapper;

        public LoggingService(IExceptionLogService exceptionLogService, IMapper mapper,IAuditLogService auditLogService)
        {
            _exceptionLogService = exceptionLogService;
            _mapper = mapper;
            _auditLogService = auditLogService;
        }

        public ServiceObjectResult<AuditLogModel> GetAuditLog(long ID)
        {
            var result = new ServiceObjectResult<AuditLogModel>();
            try
            {
                var entiy = _auditLogService.GetAuditLog(ID);
                var mappedEntity = _mapper.Map<AuditLogModel>(entiy);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<AuditLogPaginationResponse> GetAuditLogs(AuditLogModel filter, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<AuditLogPaginationResponse>();
            try
            {
                var list = _auditLogService.GetAuditLogs().AsQueryable();
                var paginatedList = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<AuditLogPaginationResponse>(paginatedList);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ExceptionLogModel> GetExceptionLog(long ID)
        {
            var result = new ServiceObjectResult<ExceptionLogModel>();
            try
            {
                var entiy = _exceptionLogService.GetExceptionLog(ID);
                var mappedEntity = _mapper.Map<ExceptionLogModel>(entiy);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ExceptionLogPaginationResponse> GetExceptionLogs(ExceptionLogModel filter, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<ExceptionLogPaginationResponse>();
            try
            {
                var list = _exceptionLogService.GetExceptionLogs().AsQueryable();
                var paginatedList = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<ExceptionLogPaginationResponse>(paginatedList);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

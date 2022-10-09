using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Logging.AuiditLog;
using ECommerce.Module.Wrapper.ServiceModels.Logging.ExceptionLog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggingController : BaseController
    {

        [Authorize(Roles = "IsGlobalAdmin,UpdateExceptionLog")]
        [HttpPost("GetExceptionLog")]
        public ServiceObjectResult<ExceptionLogModel> GetExceptionLog([FromBody] WebApiObjectRequest<ExceptionLogModel> request)
        {
            var result = new ServiceObjectResult<ExceptionLogModel>();
            try
            {
                result = this.Client.Logging.GetExceptionLog(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,ExceptionLogList")]
        [HttpPost("GetExceptionLogs")]
        public ServiceObjectResult<ExceptionLogPaginationResponse> GetExceptionLogs([FromBody] WebAPICollectionRequest<ExceptionLogModel> request)
        {
            var result = new ServiceObjectResult<ExceptionLogPaginationResponse>();
            try
            {
                result = this.Client.Logging.GetExceptionLogs(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateAuditLog")]
        [HttpPost("GetAuditLog")]
        public ServiceObjectResult<AuditLogModel> GetAuditLog([FromBody] WebApiObjectRequest<AuditLogModel> request)
        {
            var result = new ServiceObjectResult<AuditLogModel>();
            try
            {
                result = this.Client.Logging.GetAuditLog(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,AuditLogList")]
        [HttpPost("GetAuditLogs")]
        public ServiceObjectResult<AuditLogPaginationResponse> GetAuditLogs([FromBody] WebAPICollectionRequest<AuditLogModel> request)
        {
            var result = new ServiceObjectResult<AuditLogPaginationResponse>();
            try
            {
                result = this.Client.Logging.GetAuditLogs(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

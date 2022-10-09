using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Logging.AuiditLog;
using ECommerce.Module.Wrapper.ServiceModels.Logging.ExceptionLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Abstract
{
    public interface ILoggingService
    {
        ServiceObjectResult<ExceptionLogModel> GetExceptionLog(long ID);
        ServiceObjectResult<ExceptionLogPaginationResponse> GetExceptionLogs(ExceptionLogModel filter, Dynamic dynamic);
        ServiceObjectResult<AuditLogModel> GetAuditLog(long ID);
        ServiceObjectResult<AuditLogPaginationResponse> GetAuditLogs(AuditLogModel filter, Dynamic dynamic); 
    }
}

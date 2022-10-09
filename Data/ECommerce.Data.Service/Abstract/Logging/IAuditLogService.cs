using ECommerce.Data.Domain.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Logging
{
    public interface IAuditLogService
    {
        AuditLog GetAuditLog(long ID);
        IQueryable<AuditLog> GetAuditLogs(Expression<Func<AuditLog, bool>> predicate = null);
    }
}

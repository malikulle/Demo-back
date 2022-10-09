using ECommerce.Data.Domain.Logging;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Logging;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Logging
{
    public class AuditLogService : IAuditLogService
    {
        private readonly IRepository<AuditLog> _repository;

        public AuditLogService(IRepository<AuditLog> repository)
        {
            _repository = repository;
        }

        public AuditLog GetAuditLog(long ID)
        {
            return this.GetAuditLogs(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<AuditLog> GetAuditLogs(Expression<Func<AuditLog, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate);
        }
    }
}

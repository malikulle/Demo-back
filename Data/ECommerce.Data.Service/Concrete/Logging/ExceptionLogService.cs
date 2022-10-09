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
    public class ExceptionLogService : IExceptionLogService
    {
        private readonly IRepository<ExceptionLog> _repository;

        public ExceptionLogService(IRepository<ExceptionLog> repository)
        {
            _repository = repository;
        }

        public ExceptionLog GetExceptionLog(long ID)
        {
            return this.GetExceptionLogs(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<ExceptionLog> GetExceptionLogs(Expression<Func<ExceptionLog, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate);
        }
    }
}

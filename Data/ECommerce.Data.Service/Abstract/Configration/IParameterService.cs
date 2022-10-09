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
    public interface IParameterService
    {
        Parameter GetParameter(string module, string name);
        Parameter GetParameter(long ID);
        IQueryable<Parameter> GetParameters(Expression<Func<Parameter, bool>> predicate = null);
        ServiceObjectResult<Parameter> Update(Parameter entity);
    }
}

using ECommerce.Data.Domain.Configuration;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Configration;
using ECommerce.Data.Service.Constants;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Configration
{
    public class ParameterService : IParameterService
    {
        private readonly IRepository<Parameter> _repository;

        public ParameterService(IRepository<Parameter> repository)
        {
            _repository = repository;
        }

        public Parameter GetParameter(long ID)
        {
            return this.GetParameters(op => op.ID == ID).FirstOrDefault();
        }

        public Parameter GetParameter(string module, string name)
        {
            return this.GetParameters(op => op.Name == name && op.Module == module).FirstOrDefault();
        }

        public IQueryable<Parameter> GetParameters(Expression<Func<Parameter, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate);
        }

        public ServiceObjectResult<Parameter> Update(Parameter entity)
        {
            var result = new ServiceObjectResult<Parameter>();
            try
            {
                Parameter persistent = null;
                if (this.GetParameters(op => op.Name == entity.Name && op.Module == entity.Module && op.ID != entity.ID).Any())
                {
                    result.Fail(StringConstants.ParameterExist);
                    return result;
                }
                if (entity.ID > 0)
                {
                    persistent = _repository.Query().FirstOrDefault(op => op.ID == entity.ID);
                    persistent.StatusID = entity.StatusID;
                    persistent.DateModified = DateTime.Now;
                }
                else
                {
                    persistent = new Parameter();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateCreated = DateTime.Now;
                }

                persistent.Name = entity.Name;
                persistent.Module = entity.Module;
                persistent.Value = entity.Value;

                _repository.Update(persistent);
                result.SetData(persistent);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

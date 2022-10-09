using ECommerce.Data.Domain.Membership;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Membership
{
    public class PermissionService : IPermissionService
    {
        private readonly IRepository<Permission> _repository;

        public PermissionService(IRepository<Permission> repository)
        {
            _repository = repository;
        }

        public Permission GetPermission(long ID)
        {
            return this.GetPermissions(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<Permission> GetPermissions(Expression<Func<Permission, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate);
        }

        public ServiceObjectResult<Permission> Update(Permission entity)
        {
            var result = new ServiceObjectResult<Permission>();
            try
            {
                Permission persistent = null;
                if(entity.ID > 0)
                {
                    persistent = _repository.Query().FirstOrDefault(op => op.ID == entity.ID);
                    persistent.StatusID = entity.StatusID;
                    persistent.DateModified = DateTime.Now;
                }
                else
                {
                    persistent = new Permission();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateCreated = DateTime.Now;
                }
                persistent.Name = entity.Name;
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

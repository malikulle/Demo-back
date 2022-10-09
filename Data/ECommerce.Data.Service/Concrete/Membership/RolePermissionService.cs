using ECommerce.Data.Domain.Membership;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Membership
{
    public class RolePermissionService : IRolePermissionService
    {
        private readonly IRepository<RolePermission> _repository;

        public RolePermissionService(IRepository<RolePermission> repository)
        {
            _repository = repository;
        }

        public ServiceObjectResult<RolePermission> Update(RolePermission entity)
        {
            var result = new ServiceObjectResult<RolePermission>();
            try
            {
                RolePermission persistent = null;
                if(entity.ID > 0)
                {
                    persistent = _repository.Query().FirstOrDefault(op => op.ID == entity.ID);
                    persistent.StatusID = entity.StatusID;
                    persistent.DateModified = entity.DateModified;
                }
                else
                {
                    persistent = new RolePermission();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateCreated = DateTime.Now;
                }
                persistent.RoleID = entity.RoleID;
                persistent.PermissionID = entity.PermissionID;
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

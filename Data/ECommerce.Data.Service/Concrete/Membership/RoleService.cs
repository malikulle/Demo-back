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
    public class RoleService : IRoleService
    {

        private readonly IRepository<Role> _repository;
        private readonly IRepository<RolePermission> _rolePermissionRepository;
        private readonly IRolePermissionService _rolePermissionService;

        public RoleService(IRepository<Role> repository, IRepository<RolePermission> rolePermissionRepository, IRolePermissionService rolePermissionService)
        {
            _repository = repository;
            _rolePermissionRepository = rolePermissionRepository;   
            _rolePermissionService = rolePermissionService;
        }

        public List<long> GetPermissions(long ID)
        {
            return _rolePermissionRepository.Query().AsNoTracking().Where(op => op.RoleID == ID).Select(op => op.PermissionID).ToList();
        }

        public Role GetRole(long ID)
        {
            var entity = this.GetRoles(op => op.ID == ID).FirstOrDefault();
            if (entity != null)
            {
                entity.RolePermissions = _rolePermissionRepository.Query().Include(op => op.Permission).AsNoTracking().Where(op => op.RoleID == ID).ToList();
            }
            return entity;
        }

        public IQueryable<Role> GetRoles(Expression<Func<Role, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate);
        }

        public ServiceObjectResult<Role> Update(Role entity, List<long> permissions = null)
        {
            var result =new ServiceObjectResult<Role>();
            try
            {
                Role persistent = null;
                if (entity.ID > 0)
                {
                    persistent = _repository.Query().Where(op => op.ID == entity.ID).FirstOrDefault();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateModified = DateTime.Now;
                }else
                {
                    persistent = new Role();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateCreated = DateTime.Now;
                }
                persistent.Name = entity.Name;
                _repository.Update(persistent);
                result.SetData(persistent);

                if(permissions != null)
                {
                    var list = _rolePermissionRepository.Query().Where(op => op.RoleID == entity.ID).ToList();
                    foreach (var item in list)                    
                        _rolePermissionRepository.Delete(item);

                    foreach (var item in permissions)
                    {
                        var rolePermission = new RolePermission()
                        {
                            RoleID = persistent.ID,
                            PermissionID = item
                        };
                        _rolePermissionService.Update(rolePermission);
                    }
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

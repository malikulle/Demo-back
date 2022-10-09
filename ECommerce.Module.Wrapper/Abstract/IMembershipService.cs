using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Membership;
using ECommerce.Module.Wrapper.ServiceModels.Membership.Permission;
using ECommerce.Module.Wrapper.ServiceModels.Membership.Role;
using ECommerce.Module.Wrapper.ServiceModels.Membership.User;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Abstract
{
    public interface IMembershipService
    {
        ServiceObjectResult<UserRegisteredModel> Register(UserRegisterModel model);
        ServiceObjectResult<UserLoginResponse> Login(UserLoginRequest model);
        ServiceObjectResult<UserPaginationResponse> GetUsers(UserModel filter, Dynamic dynamic);
        ServiceObjectResult<UserModel> GetUser(int ID);
        ServiceObjectResult<UserModel> UpdateUser(UserModel model, IFormFile file = null);
        ServiceObjectResult<bool> DeleteUserImagePath(int ID);
        ServiceObjectResult<PermissionPaginationResponse> GetPermissions(PermissionModel filter, Dynamic dynamic);
        ServiceObjectResult<PermissionModel> GetPermission(int ID);
        ServiceObjectResult<PermissionModel> UpdatePermission(PermissionModel model);
        ServiceObjectResult<RoleModel> GetRole(int ID);
        ServiceObjectResult<RolePaginationResponse> GetRoles(RoleModel filter, Dynamic dynamic);
        ServiceObjectResult<RoleModel> UpdateRole(RoleUpdateModel model);
    }
}

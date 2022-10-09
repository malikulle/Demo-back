using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Membership;
using ECommerce.Module.Wrapper.ServiceModels.Membership.Permission;
using ECommerce.Module.Wrapper.ServiceModels.Membership.Role;
using ECommerce.Module.Wrapper.ServiceModels.Membership.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : BaseController
    {
        [Authorize(Roles = "IsGlobalAdmin,UpdatePermission")]
        [HttpPost("GetPermission")]
        public ServiceObjectResult<PermissionModel> GetPermission([FromBody] WebApiObjectRequest<PermissionModel> request)
        {
            var result = new ServiceObjectResult<PermissionModel>();
            try
            {
                result = this.Client.Membership.GetPermission(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,PermissionList")]
        [HttpPost("GetPermissions")]
        public ServiceObjectResult<PermissionPaginationResponse> GetPermissions([FromBody] WebAPICollectionRequest<PermissionModel> request)
        {
            var result = new ServiceObjectResult<PermissionPaginationResponse>();
            try
            {
                result = this.Client.Membership.GetPermissions(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdatePermission")]
        [HttpPost("UpdatePermission")]
        public ServiceObjectResult<PermissionModel> UpdatePermission([FromBody] WebApiObjectRequest<PermissionModel> request)
        {
            var result = new ServiceObjectResult<PermissionModel>();
            try
            {
                result = this.Client.Membership.UpdatePermission(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [HttpPost("Register")]
        public ServiceObjectResult<UserRegisteredModel> Register([FromBody] WebApiObjectRequest<UserRegisterModel> request)
        {
            var result = new ServiceObjectResult<UserRegisteredModel>();
            try
            {
                result = this.Client.Membership.Register(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [HttpPost("Login")]
        public ServiceObjectResult<UserLoginResponse> Login([FromBody] WebApiObjectRequest<UserLoginRequest> request)
        {
            var result = new ServiceObjectResult<UserLoginResponse>();
            try
            {
                result = this.Client.Membership.Login(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,RoleList")]
        [HttpPost("GetRole")]
        public ServiceObjectResult<RoleModel> GetRole([FromBody] WebApiObjectRequest<RoleModel> request)
        {
            var result = new ServiceObjectResult<RoleModel>();
            try
            {
                result = this.Client.Membership.GetRole(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,RoleList")]
        [HttpPost("GetRoles")]
        public ServiceObjectResult<RolePaginationResponse> GetRoles([FromBody] WebAPICollectionRequest<RoleModel> request)
        {
            var result = new ServiceObjectResult<RolePaginationResponse>();
            try
            {
                result = this.Client.Membership.GetRoles(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateRole")]
        [HttpPost("UpdateRole")]
        public ServiceObjectResult<RoleModel> UpdateRole([FromBody] WebApiObjectRequest<RoleUpdateModel> request)
        {
            var result = new ServiceObjectResult<RoleModel>();
            try
            {
                result = this.Client.Membership.UpdateRole(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateUser")]
        [HttpPost("GetUser")]
        public ServiceObjectResult<UserModel> GetUser([FromBody] WebApiObjectRequest<UserModel> request)
        {
            var result = new ServiceObjectResult<UserModel>();
            try
            {
                result = this.Client.Membership.GetUser(request.ID);
                this.Client.FormatEntity.Format(result.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UserList")]
        [HttpPost("GetUsers")]
        public ServiceObjectResult<UserPaginationResponse> GetUsers([FromBody] WebAPICollectionRequest<UserModel> request)
        {
            var result = new ServiceObjectResult<UserPaginationResponse>();
            try
            {
                result = this.Client.Membership.GetUsers(request.Data, request.DynamicFilter);

                foreach (var item in result.Data.Items)
                    this.Client.FormatEntity.Format(item);

            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateUser")]
        [HttpPost("UpdateUser")]
        public ServiceObjectResult<UserModel> UpdateUser([FromForm] UserUpdateModel request)
        {
            var result = new ServiceObjectResult<UserModel>();
            try
            {
                result = this.Client.Membership.UpdateUser(request.GetData(), request.File);
                this.Client.FormatEntity.Format(result.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateUser")]
        [HttpPost("DeleteUserImagePath")]
        public ServiceObjectResult<bool> DeleteUserImagePath([FromBody] WebApiObjectRequest<UserModel> request)
        {
            var result = new ServiceObjectResult<bool>();
            try
            {
                result = this.Client.Membership.DeleteUserImagePath(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

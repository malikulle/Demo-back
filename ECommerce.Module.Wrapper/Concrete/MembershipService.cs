using AutoMapper;
using ECommerce.Data.Domain.Membership;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Paging;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.Abstract;
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

namespace ECommerce.Module.Wrapper.Concrete
{
    public class MembershipService : IMembershipService
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IPermissionService _permissionService;
        private readonly IRoleService _roleService;
        private readonly ITokenService _tokenService;
        public MembershipService(IUserService userService, IMapper mapper, ITokenService tokenService, IPermissionService permissionService, IRoleService roleService)
        {
            _userService = userService;
            _mapper = mapper;
            _tokenService = tokenService;
            _permissionService = permissionService;
            _roleService = roleService;
        }

        public ServiceObjectResult<UserLoginResponse> Login(UserLoginRequest model)
        {
            var result = new ServiceObjectResult<UserLoginResponse>();
            try
            {
                var loginResult = _userService.Login(model.Email, model.Password);
                if (loginResult.HasFailed)
                {
                    result.Fail(loginResult);
                    return result;
                }
                var response = _mapper.Map<UserLoginResponse>(loginResult.Data);
                response.Token = _tokenService.GenerateToken(loginResult.Data);
                response.Permissions = _userService.GetPermissions(response.ID);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<UserRegisteredModel> Register(UserRegisterModel model)
        {
            var result = new ServiceObjectResult<UserRegisteredModel>();
            try
            {
                var entity = _mapper.Map<User>(model);
                var registerResult = _userService.Register(entity, model.Password);
                if (registerResult.HasFailed)
                {
                    result.Fail(registerResult);
                    return result;
                }
                var registeredModel = _mapper.Map<UserRegisteredModel>(registerResult.Data);
                registeredModel.Token = _tokenService.GenerateToken(registerResult.Data);
                registeredModel.Permissions = _userService.GetPermissions(registerResult.Data.ID);
                result.SetData(registeredModel);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<PermissionModel> GetPermission(int ID)
        {
            var result = new ServiceObjectResult<PermissionModel>();
            try
            {
                var entiy = _permissionService.GetPermission(ID);
                var mappedEntity = _mapper.Map<PermissionModel>(entiy);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<PermissionPaginationResponse> GetPermissions(PermissionModel filter, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<PermissionPaginationResponse>();
            try
            {
                var list = _permissionService.GetPermissions().AsQueryable();
                var permissions = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, dynamic.PageSize);
                var reponse = _mapper.Map<PermissionPaginationResponse>(permissions);
                result.SetData(reponse);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<RoleModel> GetRole(int ID)
        {
            var result = new ServiceObjectResult<RoleModel>();
            try
            {
                var entity = _roleService.GetRole(ID);
                var mappedEntity = _mapper.Map<RoleModel>(entity);
                if (mappedEntity != null)
                    mappedEntity.Permissions = _roleService.GetPermissions(ID);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<RolePaginationResponse> GetRoles(RoleModel filter, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<RolePaginationResponse>();
            try
            {
                var list = _roleService.GetRoles().AsQueryable();
                var roles = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<RolePaginationResponse>(roles);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
        public ServiceObjectResult<PermissionModel> UpdatePermission(PermissionModel model)
        {
            var result = new ServiceObjectResult<PermissionModel>();
            try
            {
                var entity = _mapper.Map<Permission>(model);
                var updateResult = _permissionService.Update(entity);
                if (updateResult.HasFailed)
                {
                    result.Fail(updateResult);
                    return result;
                }
                var mappedEnttiy = _mapper.Map<PermissionModel>(updateResult.Data);
                result.SetData(mappedEnttiy);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<RoleModel> UpdateRole(RoleUpdateModel model)
        {
            var result = new ServiceObjectResult<RoleModel>();
            try
            {
                var entity = _mapper.Map<Role>(model);
                var updateResult = _roleService.Update(entity, model.Permissions);
                if (updateResult.HasFailed)
                {
                    result.Fail(updateResult);
                    return result;
                }
                var mappedEnttiy = _mapper.Map<RoleModel>(updateResult.Data);
                if (mappedEnttiy != null)
                    mappedEnttiy.Permissions = _roleService.GetPermissions(mappedEnttiy.ID);
                result.SetData(mappedEnttiy);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<UserPaginationResponse> GetUsers(UserModel filter, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<UserPaginationResponse>();
            try
            {
                var list = _userService.GetUsers().AsQueryable();
                var users = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<UserPaginationResponse>(users);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<UserModel> GetUser(int ID)
        {
            var result = new ServiceObjectResult<UserModel>();
            try
            {
                var entity = _userService.GetUser(ID);
                var mappedEntity = _mapper.Map<UserModel>(entity);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<UserModel> UpdateUser(UserModel model, IFormFile file = null)
        {
            var result = new ServiceObjectResult<UserModel>();
            try
            {
                var entity = _mapper.Map<User>(model);
                var updateResult = _userService.Update(entity, model.Password, file);
                if (updateResult.HasFailed)
                {
                    result.Fail(updateResult);
                    return result;
                }
                var mappedEnttiy = _mapper.Map<UserModel>(updateResult.Data);
                result.SetData(mappedEnttiy);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<bool> DeleteUserImagePath(int ID)
        {
            var result = new ServiceObjectResult<bool>();
            try
            {
                result = _userService.DeleteImagePath(ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

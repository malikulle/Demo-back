using ECommerce.Data.Domain.Membership;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Configration;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Data.Service.Constants;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Hashing;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Framework.SharedLibary.Token;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Membership
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<RolePermission> _rolePermissionRepository;
        private readonly IImageService _imageService;

        public UserService(IRepository<User> userRepository, IRepository<RolePermission> rolePermissionRepository, IImageService imageService)
        {
            _userRepository = userRepository;
            _rolePermissionRepository = rolePermissionRepository;
            _imageService = imageService;
        }

        public bool CheckEmailExist(string email, long ID)
        {
            return this.GetUsers(op => op.EmailAddress == email && op.ID != ID).Any();
        }

        public ServiceObjectResult<bool> DeleteImagePath(long userID)
        {
            var result = new ServiceObjectResult<bool>();
            try
            {
                var persistent = _userRepository.Query().Where(op => op.ID == userID).FirstOrDefault();
                if (persistent != null && !string.IsNullOrEmpty(persistent.ImagePath))
                {
                    var imageResult = _imageService.DeleteFile(persistent.ImagePath);
                    if(!imageResult.HasFailed && imageResult.Data)
                    {
                        persistent.ImagePath = "";
                        _userRepository.Update(persistent);
                        result.SetData(true);
                    }
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public User GetByEmailAddress(string email)
        {
            return this.GetUsers(op => op.EmailAddress == email).FirstOrDefault();
        }

        public List<string> GetPermissions(long userID)
        {
            List<string> list = new List<string>();
            var user = this.GetUser(userID);
            if (user != null && user.RoleID.GetValueOrDefault(0) > 0)
                list = _rolePermissionRepository.Query().AsNoTracking().Where(op => op.RoleID == user.RoleID).Select(op => op.Permission.Name).ToList();
            if (user.IsGlobalAdmin)
                list.Add("IsGlobalAdmin");
            return list;
        }

        public User GetUser(long ID)
        {
            return this.GetUsers(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<User> GetUsers(Expression<Func<User, bool>> predicate = null)
        {
            return _userRepository.QueryAll(predicate).Include(op => op.Role);           
        }

        public ServiceObjectResult<User> Login(string email, string password)
        {
            var result = new ServiceObjectResult<User>();
            try
            {
                var user = this.GetByEmailAddress(email);
                if (user == null)
                {
                    result.Fail(StringConstants.LoginError);
                    return result;
                }
                if (!HashingHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                {
                    result.Fail(StringConstants.LoginError);
                    return result;
                }
                result.SetData(user);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<User> Register(User user, string password)
        {
            var result = new ServiceObjectResult<User>();
            try
            {
                if (this.CheckEmailExist(user.EmailAddress, user.ID))
                {
                    result.Fail(StringConstants.EmailExist);
                    return result;
                }

                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.FullName = user.Name + " " + user.Surname;
                user.StatusID = StatusValue.ActiveStatusID;

                _userRepository.Update(user);
                result.SetData(user);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<User> Update(User entity, string password = "", IFormFile file = null)
        {
            var result = new ServiceObjectResult<User>();
            try
            {
                if (this.CheckEmailExist(entity.EmailAddress, entity.ID))
                {
                    result.Fail(StringConstants.EmailExist);
                    return result;
                }

                if (entity.ID == 0 && string.IsNullOrEmpty(password))
                {
                    result.Fail(StringConstants.PasswordNull);
                    return result;
                }

                User persistent = null;
                if (entity.ID > 0)
                {
                    persistent = _userRepository.Query().Where(op => op.ID == entity.ID).FirstOrDefault();
                    persistent.StatusID = entity.StatusID;
                    persistent.DateModified = DateTime.Now;
                }
                else
                {
                    persistent = new User();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateCreated = DateTime.Now;
                }
                persistent.Name = entity.Name;
                persistent.Surname = entity.Surname;
                persistent.FullName = persistent.Name + " " + entity.Surname;
                persistent.EmailAddress = entity.EmailAddress;
                persistent.RoleID = entity.RoleID;
                if (persistent.RoleID == 0)
                    persistent.RoleID = null;
                persistent.IsGlobalAdmin = entity.IsGlobalAdmin;
                if (entity.ID == 0)
                {
                    byte[] passwordHash, passwordSalt;
                    HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

                    persistent.PasswordHash = passwordHash;
                    persistent.PasswordSalt = passwordSalt;
                }
                if (file != null)
                {
                    var imageResult = _imageService.SaveFile(file, nameof(User));
                    if (!imageResult.HasFailed && !string.IsNullOrEmpty(imageResult.Data))
                    {
                        persistent.ImagePath = imageResult.Data;
                    }
                }

                _userRepository.Update(persistent);
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

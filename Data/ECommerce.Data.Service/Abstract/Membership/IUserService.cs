using ECommerce.Data.Domain.Membership;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Membership
{
    public interface IUserService
    {
        ServiceObjectResult<User> Register(User user, string password);
        ServiceObjectResult<User> Login(string email, string password);
        ServiceObjectResult<User> Update(User entity, string password = "", IFormFile file = null);
        ServiceObjectResult<bool> DeleteImagePath(long userID);
        List<string> GetPermissions(long userID);
        IQueryable<User> GetUsers(Expression<Func<User, bool>> predicate = null);
        User GetUser(long ID);
        bool CheckEmailExist(string email, long ID);
        User GetByEmailAddress(string email);
    }
}

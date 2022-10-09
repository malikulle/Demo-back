using ECommerce.Framework.SharedLibary.Paging;
using ECommerce.Module.Wrapper.ServiceModels.Membership.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Membership.User
{
    public class UserModel
    {
        public long ID { get; set; }
        public byte StatusID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string ImagePath { get; set; }
        public bool IsGlobalAdmin { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public Nullable<long> RoleID { get; set; }
        public RoleModel Role { get; set; }
    }

    public class UserPaginationResponse : BasePageableModel
    {
        public List<UserModel> Items { get; set; }
    }
}

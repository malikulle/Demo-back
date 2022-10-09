using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Membership
{
    public class UserLoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserLoginResponse
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string ImagePath { get; set; }
        public bool IsGlobalAdmin { get; set; }
        public string Token { get; set; }
        public List<string> Permissions { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Membership.User
{
    public class UserUpdateModel
    {
        public IFormFile File { get; set; }
        public long ID { get; set; }
        public byte StatusID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string ImagePath { get; set; }
        public bool IsGlobalAdmin { get; set; }
        public string Password { get; set; }
        public Nullable<long> RoleID { get; set; }

        public UserModel GetData()
        {
            var model = new UserModel()
            {
                ID = ID,
                Name = Name,
                StatusID = StatusID,
                Surname = Surname,
                EmailAddress = EmailAddress,
                ImagePath = ImagePath,
                IsGlobalAdmin = IsGlobalAdmin,
                Password = Password,
                RoleID = RoleID
            };
            return model;
        }
    }
}

using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Membership
{
    [Table(nameof(User), Schema = "Membership")]
    public class User : DataEntity, IEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public string ImagePath { get; set; }

        public bool IsGlobalAdmin { get; set; }

        public byte[] PasswordSalt { get; set; }

        public byte[] PasswordHash { get; set; }

        public Nullable<long> RoleID { get; set; }

        public virtual Role Role { get; set; }
    }
}

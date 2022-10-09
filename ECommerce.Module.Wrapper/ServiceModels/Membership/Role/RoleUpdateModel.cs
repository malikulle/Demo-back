using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Membership.Role
{
    public class RoleUpdateModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public byte StatusID { get; set; }
        public List<long> Permissions { get; set; }
    }
}

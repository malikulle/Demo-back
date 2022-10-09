using ECommerce.Framework.SharedLibary.Paging;
using ECommerce.Module.Wrapper.ServiceModels.Membership.RolePermission;

namespace ECommerce.Module.Wrapper.ServiceModels.Membership.Role
{
    public class RoleModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public byte StatusID { get; set; }
        public List<long> Permissions { get; set; }
    }

    public class RolePaginationResponse : BasePageableModel
    {
        public List<RoleModel> Items { get; set; }
    }
}

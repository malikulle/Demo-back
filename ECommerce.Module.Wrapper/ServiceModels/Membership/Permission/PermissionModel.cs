using ECommerce.Framework.SharedLibary.Paging;

namespace ECommerce.Module.Wrapper.ServiceModels.Membership.Permission
{
    public class PermissionModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public byte StatusID { get; set; }
    }

    public class PermissionPaginationResponse : BasePageableModel
    {
        public List<PermissionModel> Items { get; set; }
    }
}

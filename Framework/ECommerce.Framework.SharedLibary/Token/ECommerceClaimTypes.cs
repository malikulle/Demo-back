using System.Security.Claims;

namespace ECommerce.Framework.SharedLibary.Token
{
    public class ECommerceClaimTypes
    {
        public static string UserID { get; set; } = ClaimTypes.NameIdentifier;
        public static string Role { get; set; } = ClaimTypes.Role;
    }
}

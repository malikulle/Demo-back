using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Membership
{
    public class RefreshTokenModel
    {
        public string Token { get; set; }
        public UserLoginResponse User { get; set; }
    }
}

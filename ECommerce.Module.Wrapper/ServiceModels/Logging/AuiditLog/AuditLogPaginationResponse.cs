using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Logging.AuiditLog
{
    public class AuditLogPaginationResponse : BasePageableModel
    {
        public List<AuditLogModel> Items{ get; set; }
    }
}

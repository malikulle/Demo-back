using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Logging.ExceptionLog
{
    public class ExceptionLogPaginationResponse : BasePageableModel
    {
        public List<ExceptionLogModel> Items { get; set; }
    }
}

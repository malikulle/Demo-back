using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Logging.ExceptionLog
{
    public class ExceptionLogModel
    {
        public long ID { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string FunctionName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Result
{
    public class ServiceResultMessage
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsWarning { get; set; }
        public bool IsError { get; set; }
        public bool IsSuccess { get; set; }
    }
}

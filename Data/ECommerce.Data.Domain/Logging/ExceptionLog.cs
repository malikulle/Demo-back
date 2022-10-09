using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Logging
{
    [Table(nameof(ExceptionLog), Schema = "Logging")]
    public class ExceptionLog : DataEntity , IEntity
    {
        public long UserID { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string IPAddress { get; set; }
        public string MachineName { get; set; }
        public string UserAgent { get; set; }
        public string SessionID { get; set; }
        public string FunctionName { get; set; }

    }
}

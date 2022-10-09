using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Enums.Configuration
{
    public enum JobExecutionType
    {
        None = 0,
        Running = 1,
        Done = 2,
    }

    public static class JobExecutionValue
    {
        public static byte None
        {
            get { return Convert.ToByte(JobExecutionType.None); }
        }

        public static byte Running
        {
            get { return Convert.ToByte(JobExecutionType.Running); }
        }

        public static byte Done
        {
            get { return Convert.ToByte(JobExecutionType.Done); }
        }
    }
}

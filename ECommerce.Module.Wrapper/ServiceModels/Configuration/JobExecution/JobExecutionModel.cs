using ECommerce.Module.Wrapper.ServiceModels.Configuration.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Configuration.JobExecution
{
    public class JobExecutionModel
    {
        public long ID { get; set; }
        public byte JobExecutionType { get; set; }
        public string JobExecutionTypeName { get; set; }
        public JobModel Job { get; set; }
        public long JobID { get; set; }
        public string JobName { get; set; }
        public DateTime StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public List<JobExecutionDetailModel> Logs { get; set; }
    }
}

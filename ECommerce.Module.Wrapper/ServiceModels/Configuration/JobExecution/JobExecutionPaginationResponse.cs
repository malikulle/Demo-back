using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Configuration.JobExecution
{
    public class JobExecutionPaginationResponse : BasePageableModel
    {
        public List<JobExecutionModel> Items { get; set; }
    }
}

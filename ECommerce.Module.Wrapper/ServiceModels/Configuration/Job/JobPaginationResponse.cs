using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Configuration.Job
{
    public class JobPaginationResponse : BasePageableModel
    {
        public List<JobModel> Items { get; set; }
    }
}

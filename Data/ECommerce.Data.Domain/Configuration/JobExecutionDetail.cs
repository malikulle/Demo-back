using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Configuration
{
    [Table(nameof(JobExecutionDetail), Schema = "Configuration")]
    public class JobExecutionDetail : DataEntity, IEntity
    {
        public string Description { get; set; }

        public long JobExecutionID { get; set; }
        public virtual JobExecution JobExecution { get; set; }

    }
}

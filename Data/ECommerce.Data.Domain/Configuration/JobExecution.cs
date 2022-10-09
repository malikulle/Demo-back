using ECommerce.Framework.SharedLibary.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Configuration
{
    [Table(nameof(JobExecution), Schema = "Configuration")]
    public class JobExecution : DataEntity, IEntity
    {
        public DateTime StartDate { get; set; }
        
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// <see cref="Domain.Enums.Configuration.JobExecutionType"/>
        /// </summary>
        public byte JobExecutionType { get; set; }


        public long JobID { get; set; }
        public virtual Job Job { get; set; }
    }
}

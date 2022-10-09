using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Attributes
{
    public class AuditLoggingAttribute : Attribute
    {
        public bool Enable { get; set; }
        public bool ParentOfPostActions { get; set; }
        public string ParentPropertyName { get; set; }
        public AuditLoggingAttribute(bool enable)
        {
            this.Enable = enable;
        }
        public AuditLoggingAttribute()
        {
            this.Enable = true;
        }
    }
}

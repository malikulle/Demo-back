using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Configuration.Parameter
{
    public class ParameterModel
    {
        public long ID { get; set; }
        public byte StatusID { get; set; }
        public string Name { get; set; }
        public string Module { get; set; }
        public string Value { get; set; }
    }
}

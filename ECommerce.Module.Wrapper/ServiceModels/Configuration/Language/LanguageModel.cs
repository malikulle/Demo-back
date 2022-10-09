using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Configuration.Language
{
    public class LanguageModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string CultureCode { get; set; }
        public string IsoCode { get; set; }
        public string ImagePath { get; set; }
        public string IconName { get; set; }
    }
}

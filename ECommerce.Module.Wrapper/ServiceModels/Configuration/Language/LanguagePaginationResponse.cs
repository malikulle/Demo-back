using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Configuration.Language
{
    public class LanguagePaginationResponse : BasePageableModel
    {
        public List<LanguageModel> Items { get; set; }
    }
}

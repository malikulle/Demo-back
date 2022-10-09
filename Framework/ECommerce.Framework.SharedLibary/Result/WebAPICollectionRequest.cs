using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Result
{
    public class WebAPICollectionRequest<T>
    {
        public T Data { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public long LanguageID { get; set; } = 0;
        public Dynamic.Dynamic DynamicFilter { get; set; }
    }
}

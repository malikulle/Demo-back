using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Dynamic
{
    public class Dynamic
    {
        public IEnumerable<Sort> Sort { get; set; }
        public Filter Filter { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public Dynamic()
        {
        }

        public Dynamic(IEnumerable<Sort>? sort, Filter? filter)
        {
            Sort = sort;
            Filter = filter;
        }
    }
}

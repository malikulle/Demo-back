using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.AddressBook.City
{
    public class CityPaginationResponse : BasePageableModel
    {
        public List<CityModel> Items { get; set; }
    }
}

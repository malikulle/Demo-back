using ECommerce.Framework.SharedLibary.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.AddressBook.Country
{
    public class CountryPaginationResponse : BasePageableModel
    {
        public List<CountryModel> Items { get; set; }
    }
}

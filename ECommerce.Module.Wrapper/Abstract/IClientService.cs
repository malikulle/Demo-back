using ECommerce.Data.Service.Abstract.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Abstract
{
    public interface IClientService
    {
        ICatalogService Catalog { get; }
        IMembershipService Membership { get; }
        IConfigurationService Configuration { get; }
        IAddressBookService AddressBook { get; }
        IAuthenticationService Authentication { get; }
        IFormatService FormatEntity { get; }
        ILoggingService Logging { get; }
        ISalesService Sales { get; }
        long CurrentUserID { get; }

    }
}

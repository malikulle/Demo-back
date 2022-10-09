using ECommerce.Framework.SharedLibary.Token;
using ECommerce.Module.Wrapper.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Concrete
{
    public class ClientService : IClientService
    {
        public ICatalogService Catalog { get; }

        public IMembershipService Membership { get; }
        public IConfigurationService Configuration { get; }
        public IAddressBookService AddressBook { get; }
        public IFormatService FormatEntity { get; }
        public IAuthenticationService Authentication { get; }
        public ILoggingService Logging { get; }
        public ISalesService Sales { get; }
        public long CurrentUserID { get; }


        public ClientService(ICatalogService catalog, IMembershipService membership, IConfigurationService configuration,IAddressBookService addressBook,IHttpContextAccessor accessor, IFormatService formatEntity,IAuthenticationService authentication,ILoggingService logging,ISalesService sales)
        {
            Catalog = catalog;
            Membership = membership;
            Configuration = configuration;
            AddressBook = addressBook;
            FormatEntity = formatEntity;
            Authentication = authentication;
            Logging = logging;
            Sales = sales;
            CurrentUserID = Convert.ToInt64(accessor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ECommerceClaimTypes.UserID)?.Value);
        }
    }
}

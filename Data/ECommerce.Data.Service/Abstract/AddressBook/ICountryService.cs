using ECommerce.Data.Domain.AddressBook;
using ECommerce.Framework.SharedLibary.Result;
using System.Linq.Expressions;

namespace ECommerce.Data.Service.Abstract.AddressBook
{
    public interface ICountryService
    {
        Country GetCountry(long ID);
        IQueryable<Country> GetCountries(Expression<Func<Country, bool>> predicate = null);
        ServiceObjectResult<Country> Update(Country entity);
    }
}

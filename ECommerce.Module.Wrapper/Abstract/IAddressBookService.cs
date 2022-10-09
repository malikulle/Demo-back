using ECommerce.Data.Domain.AddressBook;
using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.AddressBook.City;
using ECommerce.Module.Wrapper.ServiceModels.AddressBook.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Abstract
{
    public interface IAddressBookService
    {
        ServiceObjectResult<CityModel> GetCity(long ID);
        ServiceObjectResult<CityPaginationResponse> GetCities(Dynamic dynamic = null, CityModel filter = null);
        ServiceObjectResult<CityModel> UpdateCity(CityModel model);

        ServiceObjectResult<CountryModel> GetCountry(long ID);
        ServiceObjectResult<CountryPaginationResponse> GetCountries(CountryModel filter, Dynamic dynamic);
        ServiceObjectResult<CountryModel> UpdateCountry(CountryModel model);
    }
}

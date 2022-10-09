using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.AddressBook.City;
using ECommerce.Module.Wrapper.ServiceModels.AddressBook.Country;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : BaseController
    {

        [Authorize(Roles = "IsGlobalAdmin,UpdateCity")]
        [HttpPost("GetCity")]
        public ServiceObjectResult<CityModel> GetCity([FromBody] WebApiObjectRequest<CityModel> request)
        {
            var result = new ServiceObjectResult<CityModel>();
            try
            {
                result = this.Client.AddressBook.GetCity(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,CityList")]
        [HttpPost("GetCities")]
        public ServiceObjectResult<CityPaginationResponse> GetCities([FromBody] WebAPICollectionRequest<CityModel> request)
        {
            var result = new ServiceObjectResult<CityPaginationResponse>();
            try
            {
                result = this.Client.AddressBook.GetCities(request.DynamicFilter, request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateCity")]
        [HttpPost("UpdateCity")]
        public ServiceObjectResult<CityModel> UpdateCity([FromBody] WebApiObjectRequest<CityModel> request)
        {
            var result = new ServiceObjectResult<CityModel>();
            try
            {
                result = this.Client.AddressBook.UpdateCity(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateCountry")]
        [HttpPost("GetCountry")]
        public ServiceObjectResult<CountryModel> GetCountry([FromBody] WebApiObjectRequest<CountryModel> request)
        {
            var result = new ServiceObjectResult<CountryModel>();
            try
            {
                result = this.Client.AddressBook.GetCountry(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,CountryList")]
        [HttpPost("GetCountries")]
        public ServiceObjectResult<CountryPaginationResponse> GetCountries([FromBody] WebAPICollectionRequest<CountryModel> request)
        {
            var result = new ServiceObjectResult<CountryPaginationResponse>();
            try
            {
                result = this.Client.AddressBook.GetCountries(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateCountry")]
        [HttpPost("UpdateCountry")]
        public ServiceObjectResult<CountryModel> UpdateCountry([FromBody] WebApiObjectRequest<CountryModel> request)
        {
            var result = new ServiceObjectResult<CountryModel>();
            try
            {
                result = this.Client.AddressBook.UpdateCountry(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

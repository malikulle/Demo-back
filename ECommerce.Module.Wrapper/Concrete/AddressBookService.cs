using AutoMapper;
using ECommerce.Data.Domain.AddressBook;
using ECommerce.Data.Service.Abstract.AddressBook;
using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Paging;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.Abstract;
using ECommerce.Module.Wrapper.ServiceModels.AddressBook.City;
using ECommerce.Module.Wrapper.ServiceModels.AddressBook.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Concrete
{
    public class AddressBookService : IAddressBookService
    {

        private readonly ICountryService _countryService;
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public AddressBookService(ICountryService countryService, ICityService cityService, IMapper mapper)
        {
            _countryService = countryService;
            _cityService = cityService;
            _mapper = mapper;
        }

        public ServiceObjectResult<CityPaginationResponse> GetCities(Dynamic dynamic, CityModel filter = null)
        {
            var result = new ServiceObjectResult<CityPaginationResponse>();
            try
            {
                var list = _cityService.GetCities().AsQueryable();
                if (filter != null)
                {
                    if (filter.CountryID > 0)
                        list = list.Where(op => op.CountryID == filter.CountryID);
                }
                var paginatedList = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<CityPaginationResponse>(paginatedList);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<CityModel> GetCity(long ID)
        {
            var result = new ServiceObjectResult<CityModel>();
            try
            {
                var entiy = _cityService.GetCity(ID);
                var mappedEntity = _mapper.Map<CityModel>(entiy);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<CountryPaginationResponse> GetCountries(CountryModel filter,Dynamic dynamic)
        {
            var result = new ServiceObjectResult<CountryPaginationResponse>();
            try
            {
                var list = _countryService.GetCountries().AsQueryable();
                if (filter != null)
                {

                }
                var paginatedList = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<CountryPaginationResponse>(paginatedList);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<CountryModel> GetCountry(long ID)
        {
            var result = new ServiceObjectResult<CountryModel>();
            try
            {
                var entiy = _countryService.GetCountry(ID);
                var mappedEntity = _mapper.Map<CountryModel>(entiy);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<CityModel> UpdateCity(CityModel model)
        {
            var result = new ServiceObjectResult<CityModel>();
            try
            {
                var entity = _mapper.Map<City>(model);
                var updateResult = _cityService.Update(entity);
                if (updateResult.HasFailed)
                {
                    result.Fail(updateResult);
                    return result;
                }

                var mappedEntity = _mapper.Map<CityModel>(updateResult.Data);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<CountryModel> UpdateCountry(CountryModel model)
        {
            var result = new ServiceObjectResult<CountryModel>();
            try
            {
                var entity = _mapper.Map<Country>(model);
                var updateResult = _countryService.Update(entity);
                if (updateResult.HasFailed)
                {
                    result.Fail(updateResult);
                    return result;
                }

                var mappedEntity = _mapper.Map<CountryModel>(updateResult.Data);
                result.SetData(mappedEntity);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

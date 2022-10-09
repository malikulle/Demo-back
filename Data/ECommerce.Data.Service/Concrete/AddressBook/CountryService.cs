using ECommerce.Data.Domain.AddressBook;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.AddressBook;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.AddressBook
{
    public class CountryService : ICountryService
    {
        private readonly IRepository<Country> _repository;
        private readonly IRepository<City> _cityRepository;

        public CountryService(IRepository<Country> repository, IRepository<City> cityRepository)
        {
            _repository = repository;
            _cityRepository = cityRepository;
        }

        public IQueryable<Country> GetCountries(Expression<Func<Country, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate);
        }

        public Country GetCountry(long ID)
        {
            var entity = this.GetCountries(op => op.ID == ID).FirstOrDefault();
            if (entity != null)
            {
                entity.Cities = _cityRepository.Query().AsNoTracking().Where(op => op.StatusID != StatusValue.DeletedStatusID && op.CountryID == ID).ToList();
            }
            return entity;
        }

        public ServiceObjectResult<Country> Update(Country entity)
        {
            var result = new ServiceObjectResult<Country>();
            try
            {
                Country persistent = null;
                if (entity.ID > 0)
                {
                    persistent = _repository.Query().FirstOrDefault(op => op.ID == entity.ID);
                    persistent.StatusID = entity.StatusID;
                    persistent.DateModified = DateTime.Now;
                }
                else
                {
                    persistent = new Country();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateCreated = DateTime.Now;
                }

                persistent.Name = entity.Name;
                persistent.CodeISO = entity.CodeISO;
                persistent.CodeISO3 = entity.CodeISO3;
                persistent.PhoneCode = entity.PhoneCode;

                _repository.Update(persistent);
                result.SetData(persistent);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

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
    public class CityService : ICityService
    {
        private readonly IRepository<City> _repository;

        public CityService(IRepository<City> repository)
        {
            _repository = repository;
        }

        public IQueryable<City> GetCities(Expression<Func<City, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate);
        }

        public City GetCity(long ID)
        {
            return this.GetCities(op => op.ID == ID).FirstOrDefault();
        }

        public ServiceObjectResult<City> Update(City entity)
        {
            var result = new ServiceObjectResult<City>();
            try
            {
                City persistent = null;
                if (entity.ID > 0)
                {
                    persistent = _repository.Query().FirstOrDefault(op => op.ID == entity.ID);
                    persistent.StatusID = entity.StatusID;
                    persistent.DateModified = DateTime.Now;
                }
                else
                {
                    persistent = new City();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateCreated = DateTime.Now;
                }

                persistent.Name = entity.Name;
                persistent.PlateCode = entity.PlateCode;
                persistent.CountryID = entity.CountryID;

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

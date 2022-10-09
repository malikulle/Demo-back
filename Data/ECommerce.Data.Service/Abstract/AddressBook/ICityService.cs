using ECommerce.Data.Domain.AddressBook;
using ECommerce.Framework.SharedLibary.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.AddressBook
{
    public interface ICityService 
    {
        City GetCity(long ID);
        IQueryable<City> GetCities(Expression<Func<City, bool>> predicate = null);
        ServiceObjectResult<City> Update(City entity);
    }
}

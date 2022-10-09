using ECommerce.Data.Domain.Configuration;
using ECommerce.Framework.SharedLibary.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Configration
{
    public interface ILanguageService
    {
        long GetDefaultLanguageID();
        IQueryable<Language> GetLanguages(Expression<Func<Language, bool>> predicate = null);
        Language GetLanguage(long ID);
        ServiceObjectResult<Language> Update(Language entity);
    }
}

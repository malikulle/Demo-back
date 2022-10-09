using ECommerce.Data.Domain.Configuration;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Cache;
using ECommerce.Data.Service.Abstract.Configration;
using ECommerce.Data.Service.Constants;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Configration
{
    public class LanguageService : ILanguageService
    {
        private readonly IRepository<Language> _repository;
        private readonly ICacheService _cacheService;

        public LanguageService(IRepository<Language> repository, ICacheService cacheService)
        {
            _repository = repository;
            _cacheService = cacheService;   
        }

        public long GetDefaultLanguageID()
        {
            return this.GetLanguages(op => op.CultureCode == "tr").Select(op => op.ID).FirstOrDefault();
        }

        public Language GetLanguage(long ID)
        {
            return this.GetLanguages(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<Language> GetLanguages(Expression<Func<Language, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate);
        }

        public ServiceObjectResult<Language> Update(Language entity)
        {
            var result = new ServiceObjectResult<Language>();
            try
            {
                Language persistent = null;
                if(entity.ID > 0)
                {
                    persistent = _repository.Query().FirstOrDefault(op => op.ID == entity.ID);
                    persistent.StatusID = entity.StatusID;
                    persistent.DateModified = DateTime.Now;
                }
                else
                {
                    persistent = new Language();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateCreated = DateTime.Now;
                }
                persistent.Name = entity.Name;
                persistent.CultureCode = entity.CultureCode;
                persistent.IsoCode = entity.IsoCode;
                persistent.IsoCode = entity.IconName;
                _repository.Update(persistent);
                result.SetData(persistent);
                _cacheService.ClearCache(CacheConstants.LanguageList);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

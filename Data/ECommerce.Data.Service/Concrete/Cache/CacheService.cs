using ECommerce.Data.Domain.Configuration;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Cache;
using ECommerce.Data.Service.Constants;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Cache
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IRepository<Language> _languageRepository;

        public CacheService(IMemoryCache memoryCache, IRepository<Language> languageRepository)
        {
            _memoryCache = memoryCache;
            _languageRepository = languageRepository;
        }

        public void ClearCache(string key)
        {
            _memoryCache.Remove(key);
        }

        public List<Language> GetLanguages()
        {
            List<Language> list = new List<Language>();
            list = _memoryCache.Get<List<Language>>(CacheConstants.LanguageList);
            if (list == null || list.Count == 0)
            {
                list = _languageRepository.Query().AsNoTracking().Where(op => op.StatusID != StatusValue.DeletedStatusID).OrderByDescending(op => op.ID).ToList();
                _memoryCache.Set<List<Language>>(CacheConstants.LanguageList,list);
            }
            return list;
        }
    }
}

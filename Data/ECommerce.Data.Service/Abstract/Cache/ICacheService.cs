using ECommerce.Data.Domain.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Cache
{
    public interface ICacheService
    {
        List<Language> GetLanguages();
        void ClearCache(string key);
    }
}

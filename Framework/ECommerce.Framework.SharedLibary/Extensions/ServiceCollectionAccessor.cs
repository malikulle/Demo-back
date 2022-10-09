using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Extensions
{
    public class ServiceCollectionAccessor
    {
        IHttpContextAccessor HttpContextAccessor { get; set; }
        public ServiceCollectionAccessor(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
    }
}

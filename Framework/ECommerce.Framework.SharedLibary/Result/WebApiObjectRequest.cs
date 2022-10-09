using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Result
{
    public class WebApiObjectRequest<T>
    {
        public int ID { get; set; }
        public long LanguageID { get; set; }
        public T Data { get; set; }
    }
}

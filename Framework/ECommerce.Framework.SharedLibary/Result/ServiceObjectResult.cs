using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Result
{
    public class ServiceObjectResult<T> : ServiceResult
    {
        public T Data { get; set; }

        public void SetData(T data)
        {
            this.Data = data;
        }
    }
}

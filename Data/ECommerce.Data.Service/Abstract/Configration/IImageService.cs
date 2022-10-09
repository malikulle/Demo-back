using ECommerce.Framework.SharedLibary.Result;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Configration
{
    public interface IImageService
    {
        ServiceObjectResult<string> SaveFile(IFormFile file, string ClassName);
        ServiceObjectResult<bool> DeleteFile(string path);
    }
}

using ECommerce.Data.Service.Abstract.Configration;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Framework.SharedLibary.Domain.Base;
using ECommerce.Framework.SharedLibary.Extensions;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Configration
{
    public class ImageService : IImageService
    {
        private readonly Settings _settings;

        public ImageService(IOptions<Settings> options)
        {
            _settings = options.Value;
        }

        public ServiceObjectResult<bool> DeleteFile(string path)
        {
            var result = new ServiceObjectResult<bool>();
            try
            {
                string fileToDelete = _settings.ContentFolder + path;
                if (System.IO.File.Exists(fileToDelete))
                {
                    System.IO.File.Delete(fileToDelete);
                }
                result.SetData(true);

            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<string> SaveFile(IFormFile file, string ClassName)
        {
            var result = new ServiceObjectResult<string>();
            try
            {
                string path = _settings.ContentFolder + "\\Data\\" + ClassName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string oldFileName = Path.GetFileNameWithoutExtension(file.FileName);

                string fileExtension = Path.GetExtension(file.FileName);

                var dateTime = DateTime.Now;
                string newFileName = $"{dateTime.FullDateAndTimeStringWithUnderScore() + fileExtension}";

                using (var stream = new FileStream(Path.Combine(path, newFileName), FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                result.SetData($"/Data/{ClassName}/{newFileName}");
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

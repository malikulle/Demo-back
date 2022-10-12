using ECommerce.Framework.SharedLibary.Domain.Base;
using ECommerce.Module.Wrapper.Abstract;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.Product;
using ECommerce.Module.Wrapper.ServiceModels.Membership.User;
using ECommerce.Module.Wrapper.ServiceModels.Sales.BasketItem;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Concrete
{
    public class FormatService : IFormatService
    {
        private readonly Settings _settings;

        public FormatService(IOptions<Settings> options)
        {
            _settings = options.Value;
        }
        public void Format(UserModel model)
        {
            if (model != null && !string.IsNullOrEmpty(model.ImagePath))            
                model.ImagePath = _settings.CDNBaseURL + model.ImagePath;            
        }

        public void Format(ProductModel model)
        {
            if (model != null && !string.IsNullOrEmpty(model.ImagePath))
                model.ImagePath = _settings.CDNBaseURL + model.ImagePath;
        }

        public void Format(BasketItemModel model)
        {
            if (model != null && !string.IsNullOrEmpty(model.ImagePath))
                model.ImagePath = _settings.CDNBaseURL + model.ImagePath;
        }
    }
}

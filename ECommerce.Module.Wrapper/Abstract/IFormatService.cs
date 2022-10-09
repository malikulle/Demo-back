using ECommerce.Module.Wrapper.ServiceModels.Catalog.Product;
using ECommerce.Module.Wrapper.ServiceModels.Membership.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Abstract
{
    public interface IFormatService
    {
        void Format(UserModel model);
        void Format(ProductModel model);
    }
}

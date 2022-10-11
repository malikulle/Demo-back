using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Sales.Basket;
using ECommerce.Module.Wrapper.ServiceModels.Sales.BasketItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Abstract
{
    public interface ISalesService
    {
        ServiceObjectResult<BasketModel> GetCurrentUserBasket();
        ServiceObjectResult<BasketModel> AddToBasket(BasketItemModel model);
    }
}

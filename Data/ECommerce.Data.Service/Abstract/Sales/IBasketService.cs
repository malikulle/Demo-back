using ECommerce.Data.Domain.Sales;
using ECommerce.Framework.SharedLibary.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Sales
{
    public interface IBasketService
    {
        Basket GetCurrentUserBasket();
        ServiceObjectResult<Basket> Update(Basket entity);
    }
}

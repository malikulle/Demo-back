using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Sales.Basket;
using ECommerce.Module.Wrapper.ServiceModels.Sales.BasketItem;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : BaseController
    {

        [Authorize]
        [HttpPost("GetCurrentUserBasket")]
        public ServiceObjectResult<BasketModel> GetCurrentUserBasket([FromBody] WebApiObjectRequest<BasketModel> request)
        {
            var result = new ServiceObjectResult<BasketModel>();
            try
            {
                result = this.Client.Sales.GetCurrentUserBasket();
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }


        [Authorize]
        [HttpPost("AddToBasket")]
        public ServiceObjectResult<BasketModel> AddToBasket([FromBody] WebApiObjectRequest<BasketItemModel> request)
        {
            var result = new ServiceObjectResult<BasketModel>();
            try
            {
                result = this.Client.Sales.AddToBasket(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize]
        [HttpPost("RemoveFromBasket")]
        public ServiceObjectResult<BasketModel> RemoveFromBasket([FromBody] WebApiObjectRequest<BasketItemModel> request)
        {
            var result = new ServiceObjectResult<BasketModel>();
            try
            {
                result = this.Client.Sales.RemoveFromBasket(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize]
        [HttpPost("UpdateBasketQuantity")]
        public ServiceObjectResult<BasketModel> UpdateBasketQuantity([FromBody] WebApiObjectRequest<BasketItemModel> request)
        {
            var result = new ServiceObjectResult<BasketModel>();
            try
            {
                result = this.Client.Sales.UpdateBasketQuantity(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

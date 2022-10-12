using AutoMapper;
using ECommerce.Data.Service.Abstract.Sales;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.Abstract;
using ECommerce.Module.Wrapper.ServiceModels.Sales.Basket;
using ECommerce.Module.Wrapper.ServiceModels.Sales.BasketItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Concrete
{
    public class SalesService : ISalesService
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;
        private readonly IFormatService _formatService;

        public SalesService(IBasketService basketService, IMapper mapper, IFormatService formatService)
        {
            _basketService = basketService;
            _mapper = mapper;
            _formatService = formatService;
        }

        public ServiceObjectResult<BasketModel> AddToBasket(BasketItemModel model)
        {
            var result = new ServiceObjectResult<BasketModel>();
            try
            {
                var basketResult = _basketService.AddToBasket(model.BasketID, model.Quantity, model.ProductID);
                if (!basketResult.HasFailed && basketResult.Data != null)
                {
                    var mappedModel = _mapper.Map<BasketModel>(basketResult.Data);
                    result.SetData(mappedModel);
                }
                if (result.Data != null && result.Data.BasketItems != null)
                {
                    foreach (var basketItem in result.Data.BasketItems)
                        _formatService.Format(basketItem);
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<BasketModel> GetCurrentUserBasket()
        {
            var result = new ServiceObjectResult<BasketModel>();
            try
            {
                var basket = _basketService.GetCurrentUserBasket();
                if (basket != null)
                {
                    var mappedModel = _mapper.Map<BasketModel>(basket);
                    result.SetData(mappedModel);
                }
                if (result.Data != null && result.Data.BasketItems != null)
                {
                    foreach (var basketItem in result.Data.BasketItems)
                        _formatService.Format(basketItem);
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<BasketModel> RemoveFromBasket(BasketItemModel model)
        {
            var result = new ServiceObjectResult<BasketModel>();
            try
            {
                var basketResult = _basketService.RemoveFromBasket(model.BasketID, model.ProductID);
                if (!basketResult.HasFailed && basketResult.Data != null)
                {
                    var mappedModel = _mapper.Map<BasketModel>(basketResult.Data);
                    result.SetData(mappedModel);
                }
                if (result.Data != null && result.Data.BasketItems != null)
                {
                    foreach (var basketItem in result.Data.BasketItems)
                        _formatService.Format(basketItem);
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<BasketModel> UpdateBasketQuantity(BasketItemModel model)
        {
            var result = new ServiceObjectResult<BasketModel>();
            try
            {
                var basketResult = _basketService.UpdateQuantity(model.BasketID,model.Quantity,model.ProductID);
                if (!basketResult.HasFailed && basketResult.Data != null)
                {
                    var mappedModel = _mapper.Map<BasketModel>(basketResult.Data);
                    result.SetData(mappedModel);
                }
                if (result.Data != null && result.Data.BasketItems != null)
                {
                    foreach (var basketItem in result.Data.BasketItems)
                        _formatService.Format(basketItem);
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

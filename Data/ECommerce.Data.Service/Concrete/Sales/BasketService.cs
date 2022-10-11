using ECommerce.Data.Domain.Catalog;
using ECommerce.Data.Domain.Enums.Sales;
using ECommerce.Data.Domain.Sales;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Data.Service.Abstract.Sales;
using ECommerce.Data.Service.Constants;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Sales
{
    public class BasketService : IBasketService
    {
        private readonly IRepository<Basket> _repository;
        private readonly IRepository<BasketItem> _basketItemRepository;
        private readonly ITokenService _tokenService;
        private readonly IRepository<Product> _productRepository;

        public BasketService(IRepository<Basket> repository, IRepository<BasketItem> basketItemRepository, ITokenService tokenService, IRepository<Product> productRepository)
        {
            _repository = repository;
            _basketItemRepository = basketItemRepository;
            _tokenService = tokenService;
            _productRepository = productRepository;
        }

        public ServiceObjectResult<Basket> AddToBasket(long basketID, int quantity, long productID)
        {
            var result = new ServiceObjectResult<Basket>();
            try
            {
                var userID = _tokenService.GetCurrentUserID();
                Basket persistent = null;
                if (basketID == 0)
                {
                    persistent = _repository.QueryAll(op => op.UserID == userID && op.BasketStatus == BasketStatusValue.InProgress)
                        .Include(op => op.BasketItems).FirstOrDefault();
                    if (persistent == null)
                        persistent = this.CreateEmptyBasket(userID);

                }
                else
                    persistent = this.GetBasket(basketID);

                if (persistent == null)
                {
                    result.Fail(StringConstants.BasketError);
                    return result;
                }

                if (persistent.BasketItems == null)
                    persistent.BasketItems = new List<BasketItem>();

                var basketItem = persistent.BasketItems.FirstOrDefault(op => op.ProductID == productID);

                if (basketItem != null)
                {
                    basketItem.Quantity = quantity;
                }
                else
                {
                    basketItem = new BasketItem()
                    {
                        BasketID = basketID,
                        Quantity = quantity,
                        ProductID = productID
                    };
                    persistent.BasketItems.Add(basketItem);
                }

                this.Update(persistent);
                result.SetData(this.GetBasket(persistent.ID));
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public Basket GetCurrentUserBasket()
        {
            var userID = _tokenService.GetCurrentUserID();
            var entity = _repository.QueryAll(op => op.UserID == userID && op.BasketStatus == BasketStatusValue.InProgress).FirstOrDefault();
            if(entity != null)
            {
                entity.BasketItems = _basketItemRepository.QueryAll(op => op.BasketID == entity.ID).Include(op => op.Product).ToList();
            }
            return entity;
        }

        public Basket GetBasket(long ID)
        {
            var entity = _repository.QueryAll(op => op.ID == ID).FirstOrDefault();
            if (entity != null)
            {
                entity.BasketItems = _basketItemRepository.QueryAll(op => op.BasketID == entity.ID).Include(op => op.Product).ToList();
            }
            return entity;
        }

        public ServiceObjectResult<Basket> Update(Basket entity)
        {
            var result = new ServiceObjectResult<Basket>();
            try
            {
                Basket persistent = null;
                if (entity != null)
                {
                    persistent = _repository.Query().Where(op => op.ID == entity.ID).FirstOrDefault();
                    persistent.DateModified = DateTime.Now;
                    persistent.StatusID = entity.StatusID;
                }
                else
                {
                    persistent = new Basket();
                    persistent.DateCreated = DateTime.Now;
                    persistent.StatusID = entity.StatusID;
                }
                this.UpdatePrice(entity);
                persistent.UserID = entity.UserID;
                persistent.PaymentMethod = entity.PaymentMethod;
                persistent.BasketStatus = entity.BasketStatus;
                persistent.TotalPrice = entity.TotalPrice;
                persistent.BasketPrice = entity.BasketPrice;
                persistent.TaxPrice = entity.TaxPrice;
                persistent.ShippingPrice = entity.ShippingPrice;
                _repository.Update(persistent);

                if (entity.BasketItems != null)
                {
                    var basketItems = _basketItemRepository.Query().Where(op => op.BasketID == persistent.ID).ToList();
                    foreach (var basketItem in basketItems)
                        _basketItemRepository.Delete(basketItem);

                    foreach (var item in entity.BasketItems)
                    {
                        var basketItem = new BasketItem()
                        {
                            BasketID = persistent.ID,
                            ProductID = item.ProductID,
                            Quantity = item.Quantity,
                            Price = item.Price,
                            TotalPrice = item.TotalPrice,
                            StatusID = StatusValue.ActiveStatusID,
                            DateCreated = DateTime.Now,
                            DateModified = DateTime.Now,
                        };
                        _basketItemRepository.Update(basketItem);
                    }
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public void UpdatePrice(Basket entity)
        {
            decimal BasketPrice = 0;
            decimal ShippingPrice = 10;
            if (entity.BasketItems != null)
            {

                foreach (var basketItem in entity.BasketItems)
                {
                    basketItem.Product = _productRepository.Get(basketItem.ProductID);
                    basketItem.Price = basketItem.Product.Price;
                    basketItem.TotalPrice = basketItem.Price * basketItem.Quantity;
                    BasketPrice += basketItem.TotalPrice;
                }
            }
            entity.BasketPrice = BasketPrice;
            entity.TaxPrice = Math.Round((BasketPrice * (decimal)(0.18)), 2, MidpointRounding.AwayFromZero);
            entity.ShippingPrice = ShippingPrice;
            entity.TotalPrice = entity.BasketPrice + entity.TaxPrice + entity.ShippingPrice;
        }

        public Basket CreateEmptyBasket(long userID)
        {
            var basket = new Basket();
            basket.UserID = userID;
            basket.BasketStatus = BasketStatusValue.InProgress;
            _repository.Update(basket);
            return basket;
            ;
        }

        
    }
}

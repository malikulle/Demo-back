using ECommerce.Data.Domain.Catalog;
using ECommerce.Data.Domain.Enums.Sales;
using ECommerce.Data.Domain.Sales;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Data.Service.Abstract.Sales;
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

        public Basket GetCurrentUserBasket()
        {
            var userID = _tokenService.GetCurrentUserID();
            var entity = _repository.QueryAll(op => op.UserID == userID && op.BasketStatus == BasketStatusValue.InProgress).Include(op => op.BasketItems).FirstOrDefault();
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
                    if (entity.ID == 0)
                        persistent = _repository.Query().Where(op => op.UserID == entity.UserID && op.BasketStatus == BasketStatusValue.InProgress).FirstOrDefault();
                    else
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
            decimal TaxPrice = 0;
            decimal ShippingPrice = 0;
            if(entity.BasketItems != null)
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
            entity.TaxPrice = TaxPrice;
            entity.ShippingPrice = ShippingPrice;
            entity.TotalPrice = entity.BasketPrice + entity.TaxPrice + entity.ShippingPrice;
        }
    }
}

using ECommerce.Data.Domain.Catalog;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Catalog;
using ECommerce.Data.Service.Abstract.Configration;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Catalog
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;
        private readonly IImageService _imageService;
        private readonly ILanguageService _languageService;
        private readonly IRepository<Product_i18n> _productI18NService;

        public ProductService(IRepository<Product> repository, IImageService imageService, ILanguageService languageService, IRepository<Product_i18n> productI18NService)
        {
            _repository = repository;
            _imageService = imageService;
            _languageService = languageService;
            _productI18NService = productI18NService;
        }

        public ServiceObjectResult<bool> CheckProductStatus(Product product)
        {
            var result = new ServiceObjectResult<bool>();
            try
            {
                byte status = StatusValue.PassiveStatusID;
                if (!string.IsNullOrEmpty(product.ImagePath))
                    status = StatusValue.ActiveStatusID;
                this.Update(product);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<bool> DeleteImagePath(long ID)
        {
            var result = new ServiceObjectResult<bool>();
            try
            {
                var persistent = _repository.Query().Where(op => op.ID == ID).FirstOrDefault();
                if (persistent != null && !string.IsNullOrEmpty(persistent.ImagePath))
                {
                    var imageResult = _imageService.DeleteFile(persistent.ImagePath);
                    if (!imageResult.HasFailed && imageResult.Data)
                    {
                        persistent.ImagePath = "";
                        _repository.Update(persistent);
                        result.SetData(true);
                    }
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public Product GetProduct(long ID)
        {
            return this.GetProducts(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<Product> GetProducts(Expression<Func<Product, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate).Include(op => op.Product_i18n)
                .Include(op => op.Category)
                    .ThenInclude(op => op.Category_i18n);
        }

        public ServiceObjectResult<Product> Update(Product entity, long languageID = 0, IFormFile file = null)
        {
            var result = new ServiceObjectResult<Product>();
            try
            {
                Product persistent = null;
                if (entity.ID > 0)
                {
                    persistent = _repository.Query().Where(op => op.ID == entity.ID).FirstOrDefault();
                    persistent.StatusID = entity.StatusID;
                    persistent.DateModified = DateTime.Now;
                }
                else
                {
                    persistent = new Product();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateModified = DateTime.Now;
                }
                persistent.Name = entity.Name;
                persistent.Description = entity.Description;
                persistent.Price = entity.Price;
                persistent.CategoryID = entity.CategoryID;
                if (file != null)
                {
                    var imageResult = _imageService.SaveFile(file, nameof(Product));
                    if (!imageResult.HasFailed && !string.IsNullOrEmpty(imageResult.Data))
                    {
                        persistent.ImagePath = imageResult.Data;
                    }
                }
                _repository.Update(persistent);
                if (persistent.ID > 0)
                {
                    this.Update_I18N(persistent.ID, languageID, persistent.Name, persistent.Description);
                    result.SetData(this.GetProduct(persistent.ID));
                }

            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        private ServiceObjectResult<Product_i18n> Update_I18N(long ID, long LanguageID, string Name, string Description)
        {
            var result = new ServiceObjectResult<Product_i18n>();
            try
            {
                if (LanguageID == 0)
                    LanguageID = _languageService.GetDefaultLanguageID();

                var persistent = _productI18NService.Query().Where(op => op.LanguageID == LanguageID && op.ProductID == ID).FirstOrDefault();
                if (persistent == null)
                {
                    persistent = new Product_i18n();
                    persistent.LanguageID = LanguageID;
                    persistent.ProductID = ID;
                    persistent.StatusID = StatusValue.ActiveStatusID;
                }
                persistent.Name = Name;
                persistent.Description = Description;
                _productI18NService.Update(persistent);
                result.SetData(persistent);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

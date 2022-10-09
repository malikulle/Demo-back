using AutoMapper;
using ECommerce.Data.Domain.Catalog;
using ECommerce.Data.Service.Abstract.Catalog;
using ECommerce.Data.Service.Abstract.Membership;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Paging;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.Abstract;
using ECommerce.Module.Wrapper.Helpers;
using ECommerce.Module.Wrapper.ServiceModels.Catalog;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.Product;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.ProductComment;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Concrete
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatagoryService _catagoryService;
        private readonly IProductService _productService;
        private readonly IFormatService _formatService;
        private readonly IProductCommentService _productCommentService;
        private readonly IMapper _mapper;

        public CatalogService(ICatagoryService catagoryService, IProductService productService, IFormatService formatService, IMapper mapper, IProductCommentService productCommentService)
        {
            _catagoryService = catagoryService;
            _productService = productService;
            _formatService = formatService;
            _mapper = mapper;
            _productCommentService = productCommentService;
        }

        #region Category
        public ServiceObjectResult<CategoryPaginationReponse> GetCategories(CategoryModel filter, Dynamic dynamic, long languageID = 0)
        {
            var result = new ServiceObjectResult<CategoryPaginationReponse>();
            try
            {
                var list = _catagoryService.GetCategories().AsQueryable();
                if (filter != null)
                {
                    if (filter.StatusID == StatusValue.ActiveStatusID)
                        list = list.Where(op => op.StatusID == StatusValue.ActiveStatusID);
                }
                var categories = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<CategoryPaginationReponse>(categories);
                result.SetData(response);
                if (response.Items.Count > 0)
                {
                    foreach (var item in response.Items)
                        item.Name = Translation.GetCategoryName(item, languageID);
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<CategoryResponse> GetCategory(int ID)
        {
            var result = new ServiceObjectResult<CategoryResponse>();
            try
            {
                var category = _catagoryService.GetCategory(ID);
                var categoryResponse = _mapper.Map<CategoryResponse>(category);
                result.SetData(categoryResponse);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ProductModel> GetProduct(long ID)
        {
            var result = new ServiceObjectResult<ProductModel>();
            try
            {
                var entity = _productService.GetProduct(ID);
                var mappedModel = _mapper.Map<ProductModel>(entity);
                result.SetData(mappedModel);
                if (result.Data != null)
                    _formatService.Format(result.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ProductPaginationResponse> GetProducts(ProductModel filter, Dynamic dynamic, long languageID)
        {
            var result = new ServiceObjectResult<ProductPaginationResponse>();
            try
            {
                var list = _productService.GetProducts().AsQueryable();
                if (filter != null)
                {
                    if (filter.CategoryIDs != null && filter.CategoryIDs.Any())
                        list = list.Where(op => filter.CategoryIDs.Contains(op.CategoryID));

                    if (filter.CategoryID > 0)
                        list = list.Where(op => op.CategoryID == filter.CategoryID);

                    if (filter.StatusID == StatusValue.ActiveStatusID)
                        list = list.Where(op => op.StatusID == StatusValue.ActiveStatusID);

                }
                var paginetedList = list.ToDynamic(dynamic).ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<ProductPaginationResponse>(paginetedList);
                result.SetData(response);
                if (result.Data.Items.Count > 0)
                {
                    foreach (var item in response.Items)
                    {
                        item.Name = Translation.GetProductName(item, languageID);
                        item.Description = Translation.GetProductDescription(item, languageID);
                        item.CategoryName = Translation.GetCategoryName(item.Category, languageID);
                        _formatService.Format(item);
                    }
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<CategoryResponse> UpdateCategory(CategoryModel model, long languageID = 0)
        {
            var result = new ServiceObjectResult<CategoryResponse>();
            try
            {
                var entity = _mapper.Map<Category>(model);
                var createResult = _catagoryService.Update(entity, languageID);
                if (createResult.HasFailed)
                    result.Fail(createResult.Messages);
                else
                {
                    var categoryResponse = _mapper.Map<CategoryResponse>(createResult.Data);
                    result.SetData(categoryResponse);
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ProductModel> UpdateProduct(ProductModel model, IFormFile file = null, long languageID = 0)
        {
            var result = new ServiceObjectResult<ProductModel>();
            try
            {
                var entity = _mapper.Map<Product>(model);
                var updateResult = _productService.Update(entity, languageID, file);
                if (updateResult.HasFailed)
                    result.Fail(updateResult.Messages);
                else
                {
                    var response = _mapper.Map<ProductModel>(updateResult.Data);
                    result.SetData(response);
                }
                if (result.Data != null)
                    _formatService.Format(result.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        #endregion


        public ServiceObjectResult<bool> DeleteProductImagePath(long ID)
        {
            return _productService.DeleteImagePath(ID);
        }

        public ServiceObjectResult<List<ProductModel>> GetTopViewProducts(long languageID)
        {
            var result = new ServiceObjectResult<List<ProductModel>>();
            try
            {
                var list = _productService.GetProducts().AsQueryable();
                var paginetedList = list.ToPaginate(index: 1, size: 4);
                var response = _mapper.Map<ProductPaginationResponse>(paginetedList);
                result.SetData(response.Items);
                if (result.Data.Count > 0)
                {
                    foreach (var item in result.Data)
                    {
                        item.Name = Translation.GetProductName(item, languageID);
                        item.Description = Translation.GetProductDescription(item, languageID);
                        item.CategoryName = Translation.GetCategoryName(item.Category, languageID);
                        _formatService.Format(item);
                    }
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ProductCommentModel> UpdateProductComment(ProductCommentModel model)
        {
            var result = new ServiceObjectResult<ProductCommentModel>();
            try
            {
                var entity = _mapper.Map<ProductComment>(model);
                var updateResult = _productCommentService.Update(entity);
                if (updateResult.HasFailed)
                    result.Fail(updateResult.Messages);
                else
                {
                    var response = _mapper.Map<ProductCommentModel>(updateResult.Data);
                    result.SetData(response);
                }
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        public ServiceObjectResult<ProductCommentPaginationResponse> GetProductComments(ProductCommentModel filter, Dynamic dynamic)
        {
            var result = new ServiceObjectResult<ProductCommentPaginationResponse>();
            try
            {
                var list = _productCommentService.GetProductComments().AsQueryable();
                var paginetedList = list.ToPaginate(index: dynamic.Page, size: dynamic.PageSize);
                var response = _mapper.Map<ProductCommentPaginationResponse>(paginetedList);
                result.SetData(response);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

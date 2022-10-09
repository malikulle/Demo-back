using ECommerce.Data.Domain.Catalog;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Catalog;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.Product;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.ProductComment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : BaseController
    {

        [HttpPost("GetCategory")]
        public ServiceObjectResult<CategoryResponse> GetCategory([FromBody] WebApiObjectRequest<CategoryModel> request)
        {
            var result = new ServiceObjectResult<CategoryResponse>();
            try
            {
                result = this.Client.Catalog.GetCategory(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [HttpPost("GetCategories")]
        public ServiceObjectResult<CategoryPaginationReponse> GetCategories([FromBody] WebAPICollectionRequest<CategoryModel> request)
        {
            var result = new ServiceObjectResult<CategoryPaginationReponse>();
            try
            {
                result = this.Client.Catalog.GetCategories(request.Data, request.DynamicFilter, request.LanguageID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateCategory")]
        [HttpPost("UpdateCategory")]
        public ServiceObjectResult<CategoryResponse> UpdateCategory([FromBody] WebApiObjectRequest<CategoryModel> request)
        {
            var result = new ServiceObjectResult<CategoryResponse>();
            try
            {
                result = this.Client.Catalog.UpdateCategory(request.Data, request.LanguageID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [HttpPost("GetProduct")]
        public ServiceObjectResult<ProductModel> GetProduct([FromBody] WebApiObjectRequest<ProductModel> request)
        {
            var result = new ServiceObjectResult<ProductModel>();
            try
            {
                result = this.Client.Catalog.GetProduct(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [HttpPost("GetProducts")]
        public ServiceObjectResult<ProductPaginationResponse> GetProducts([FromBody] WebAPICollectionRequest<ProductModel> request)
        {
            var result = new ServiceObjectResult<ProductPaginationResponse>();
            try
            {
                result = this.Client.Catalog.GetProducts(request.Data, request.DynamicFilter, request.LanguageID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [HttpPost("GetTopViewProducts")]
        public ServiceObjectResult<List<ProductModel>> GetTopViewProducts([FromBody] WebAPICollectionRequest<ProductModel> request)
        {
            var result = new ServiceObjectResult<List<ProductModel>>();
            try
            {
                result = this.Client.Catalog.GetTopViewProducts(request.LanguageID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateProduct")]
        [HttpPost("UpdateProduct")]
        public ServiceObjectResult<ProductModel> UpdateProduct([FromForm] ProductUpdateModel request)
        {
            var result = new ServiceObjectResult<ProductModel>();
            try
            {
                result = this.Client.Catalog.UpdateProduct(request.GetData(), request.File, request.LanguageID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [Authorize(Roles = "IsGlobalAdmin,UpdateProduct")]
        [HttpPost("DeleteProductImagePath")]
        public ServiceObjectResult<bool> DeleteProductImagePath([FromBody] WebApiObjectRequest<ProductModel> request)
        {
            var result = new ServiceObjectResult<bool>();
            try
            {
                result = this.Client.Catalog.DeleteProductImagePath(request.ID);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [HttpPost("UpdateProductComment")]
        public ServiceObjectResult<ProductCommentModel> UpdateProductComment([FromBody] WebApiObjectRequest<ProductCommentModel> request)
        {
            var result = new ServiceObjectResult<ProductCommentModel>();
            try
            {
                if (request.Data != null)
                    request.Data.UserID = this.Client.CurrentUserID;
                result = this.Client.Catalog.UpdateProductComment(request.Data);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        [HttpPost("GetProductComments")]
        public ServiceObjectResult<ProductCommentPaginationResponse> GetProductComments([FromBody] WebAPICollectionRequest<ProductCommentModel> request)
        {
            var result = new ServiceObjectResult<ProductCommentPaginationResponse>();
            try
            {               
                result = this.Client.Catalog.GetProductComments(request.Data, request.DynamicFilter);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }
    }
}

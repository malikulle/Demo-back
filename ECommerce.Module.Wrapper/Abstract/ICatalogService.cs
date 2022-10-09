using ECommerce.Data.Domain.Catalog;
using ECommerce.Framework.SharedLibary.Dynamic;
using ECommerce.Framework.SharedLibary.Result;
using ECommerce.Module.Wrapper.ServiceModels.Catalog;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.Product;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.ProductComment;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Abstract
{
    public interface ICatalogService
    {
        ServiceObjectResult<CategoryResponse> GetCategory(int ID);
        ServiceObjectResult<CategoryPaginationReponse> GetCategories(CategoryModel filter, Dynamic dynamic, long languageID = 0);
        ServiceObjectResult<CategoryResponse> UpdateCategory(CategoryModel model, long languageID = 0);

        ServiceObjectResult<ProductModel> GetProduct(long ID);
        ServiceObjectResult<ProductPaginationResponse> GetProducts(ProductModel filter, Dynamic dynamic, long languageID);
        ServiceObjectResult<List<ProductModel>> GetTopViewProducts(long languageID);
        ServiceObjectResult<ProductModel> UpdateProduct(ProductModel model, IFormFile file = null, long languageID = 0);
        ServiceObjectResult<bool> DeleteProductImagePath(long ID);

        ServiceObjectResult<ProductCommentModel> UpdateProductComment(ProductCommentModel model);
        ServiceObjectResult<ProductCommentPaginationResponse> GetProductComments(ProductCommentModel filter, Dynamic dynamic);

    }
}

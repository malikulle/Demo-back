using ECommerce.Data.Domain.Catalog;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Abstract.Catalog
{
    public interface IProductService
    {
        IQueryable<Product> GetProducts(Expression<Func<Product, bool>> predicate = null);
        Product GetProduct(long ID);
        ServiceObjectResult<Product> Update(Product entity, long languageID = 0, IFormFile file = null);
        ServiceObjectResult<bool> DeleteImagePath(long ID);
        ServiceObjectResult<bool> CheckProductStatus(Product product);
    }
}

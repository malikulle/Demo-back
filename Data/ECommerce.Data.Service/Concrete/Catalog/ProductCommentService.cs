using ECommerce.Data.Domain.Catalog;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Catalog;
using ECommerce.Framework.SharedLibary.Domain.Enums;
using ECommerce.Framework.SharedLibary.Result;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Service.Concrete.Catalog
{
    public class ProductCommentService : IProductCommentService
    {

        private readonly IRepository<ProductComment> _repository;

        public ProductCommentService(IRepository<ProductComment> repository)
        {
            _repository = repository;
        }

        public ProductComment GetProductComment(long ID)
        {
            return this.GetProductComments(op => op.ID == ID).FirstOrDefault();
        }

        public IQueryable<ProductComment> GetProductComments(Expression<Func<ProductComment, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate).Include(op => op.User).Include(op => op.Product);
        }

        public ServiceObjectResult<ProductComment> Update(ProductComment entity)
        {
            var result = new ServiceObjectResult<ProductComment>();
            try
            {
                ProductComment persistent = null;
                if(entity.ID > 0)
                {
                    persistent = _repository.Query().Where(op => op.ID == entity.ID).FirstOrDefault();
                    persistent.DateModified = DateTime.Now;
                    persistent.StatusID = entity.StatusID;
                }
                else
                {
                    persistent = new ProductComment();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                    persistent.DateCreated = DateTime.Now;
                }
                persistent.Text = entity.Text;
                persistent.UserID = entity.UserID;
                persistent.ProductID = entity.ProductID;

                _repository.Update(persistent);
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

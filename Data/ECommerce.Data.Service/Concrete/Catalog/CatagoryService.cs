using ECommerce.Data.Domain.Catalog;
using ECommerce.Data.Persistence.Repository;
using ECommerce.Data.Service.Abstract.Catalog;
using ECommerce.Data.Service.Abstract.Configration;
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
    public class CatagoryService : ICatagoryService
    {
        private readonly IRepository<Category> _repository;
        private readonly IRepository<Category_i18n> _categoryI18NRepository;
        private readonly ILanguageService _languageService;

        public CatagoryService(IRepository<Category> repository, IRepository<Category_i18n> categoryI18NRepository, ILanguageService languageService)
        {
            _repository = repository;
            _categoryI18NRepository = categoryI18NRepository;
            _languageService = languageService;
        }

        public IQueryable<Category> GetCategories(Expression<Func<Category, bool>> predicate = null)
        {
            return _repository.QueryAll(predicate).Include(op => op.Category_i18n);
        }

        public Category GetCategory(long ID)
        {
            return this.GetCategories(op => op.ID == ID).FirstOrDefault();
        }

        public bool IsNameExist(long ID, string name)
        {
            return this.GetCategories(op => op.Name == name && op.ID != ID).Any();
        }

        public ServiceObjectResult<Category> Update(Category entity, long languageID = 0)
        {
            var result = new ServiceObjectResult<Category>();
            try
            {
                if (string.IsNullOrEmpty(entity.Name))
                {
                    result.Fail("NameIsNotEmpty");
                    return result;
                }
                if (this.IsNameExist(entity.ID, entity.Name))
                {
                    result.Fail("CategoryNameExist");
                    return result;
                }
                Category persistent = null;
                if (entity.ID > 0)
                {
                    persistent = _repository.Query().Where(op => op.ID == entity.ID).FirstOrDefault();
                    persistent.StatusID = entity.StatusID;
                }
                else
                {
                    persistent = new Category();
                    persistent.StatusID = StatusValue.ActiveStatusID;
                }

                if (entity.StatusID != StatusValue.DeletedStatusID)
                {
                    persistent.Name = entity.Name;
                }
                _repository.Update(persistent);

                if (persistent.ID > 0)
                {
                    this.Update_I18N(persistent.ID, languageID, persistent.Name);
                    persistent = this.GetCategory(persistent.ID);
                }

                result.SetData(persistent);
            }
            catch (Exception ex)
            {
                result.Fail(ex);
            }
            return result;
        }

        private ServiceObjectResult<Category_i18n> Update_I18N(long ID, long LanguageID, string Name)
        {
            var result = new ServiceObjectResult<Category_i18n>();
            try
            {
                if (LanguageID == 0)
                    LanguageID = _languageService.GetDefaultLanguageID();

                var persistent = _categoryI18NRepository.Query().Where(op => op.LanguageID == LanguageID && op.CategoryID == ID).FirstOrDefault();
                if (persistent == null)
                {
                    persistent = new Category_i18n();
                    persistent.CategoryID = ID;
                    persistent.LanguageID = LanguageID;
                    persistent.StatusID = StatusValue.ActiveStatusID;
                }
                persistent.Name = Name;
                _categoryI18NRepository.Update(persistent);
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

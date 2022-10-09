using ECommerce.Module.Wrapper.ServiceModels.Catalog;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Helpers
{
    public static class Translation
    {
        public static string GetProductName(ProductModel model, long languageID)
        {
            string name = model.Name;
            if (model.Product_i18n != null && model.Product_i18n.Any())
            {
                var i18n = model.Product_i18n.Where(op => op.LanguageID == languageID).FirstOrDefault();
                if (i18n != null)
                    name = i18n.Name;
            }
            return name;
        }

        public static string GetProductDescription(ProductModel model, long languageID)
        {
            string name = model.Description;
            if (model.Product_i18n != null && model.Product_i18n.Any())
            {
                var i18n = model.Product_i18n.Where(op => op.LanguageID == languageID).FirstOrDefault();
                if (i18n != null)
                    name = i18n.Description;
            }
            return name;
        }

        public static string GetCategoryName(CategoryResponse model, long languageID)
        {
            string name = model.Name;
            if (model.Category_i18n != null && model.Category_i18n.Any())
            {
                var i18n = model.Category_i18n.Where(op => op.LanguageID == languageID).FirstOrDefault();
                if (i18n != null)
                    name = i18n.Name;
            }
            return name;
        }
    }
}

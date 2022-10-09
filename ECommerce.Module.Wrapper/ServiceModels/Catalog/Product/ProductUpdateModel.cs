using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Catalog.Product
{
    public class ProductUpdateModel
    {
        public IFormFile File { get; set; }
        public long LanguageID { get; set; }
        public long ID { get; set; }
        public byte StatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public long CategoryID { get; set; }

        public ProductModel GetData()
        {
            var model = new ProductModel()
            {
                ID = this.ID,
                Name = this.Name,
                Description = this.Description,
                StatusID = this.StatusID, 
                Price = this.Price,
                CategoryID = this.CategoryID
            };
            return model;
        }
    }
}

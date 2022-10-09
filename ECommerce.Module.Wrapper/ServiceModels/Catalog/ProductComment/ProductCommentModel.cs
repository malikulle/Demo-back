using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Catalog.ProductComment
{
    public class ProductCommentModel
    {
        public long ID { get; set; }
        public byte StatusID { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public long ProductID { get; set; }
        public long UserID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Sales.BasketItem
{
    public class BasketItemModel
    {
        public long ID { get; set; }
        public long ProductID { get; set; }
        public long BasketID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Price { get; set; }
    }
}

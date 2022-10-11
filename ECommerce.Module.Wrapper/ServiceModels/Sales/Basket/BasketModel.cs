using ECommerce.Module.Wrapper.ServiceModels.Sales.BasketItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.Sales.Basket
{
    public class BasketModel
    {
        public long ID { get; set; }
        public long UserID { get; set; }
        public byte PaymentMethod { get; set; }
        public byte BasketStatus { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal BasketPrice { get; set; }
        public decimal TaxPrice { get; set; }
        public decimal ShippingPrice { get; set; }

        public ICollection<BasketItemModel> BasketItems { get; set; }
    }
}

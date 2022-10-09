using ECommerce.Module.Wrapper.ServiceModels.AddressBook.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.AddressBook.Country
{
    public class CountryModel
    {
        public long ID { get; set; }
        public byte StatusID { get; set; }
        public string Name { get; set; }
        public string CodeISO { get; set; }
        public string CodeISO3 { get; set; }
        public string PhoneCode { get; set; }
        public List<CityModel> Cities { get; set; }
    }
}

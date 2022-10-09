using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.ServiceModels.AddressBook.City
{
    public class CityModel
    {
        public int ID { get; set; }
        public byte StatusID { get; set; }
        public string Name { get; set; }
        public string PlateCode { get; set; }
        public long CountryID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Domain.Base
{
    public class DataEntity
    {
        public long ID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public long UserCreatedID { get; set; }
        public long UserModifiedID { get; set; }
        public byte StatusID { get; set; }

    }
}

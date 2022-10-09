using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Domain.Enums
{
    public enum StatusType : byte
    {
        Passive = 0,
        Active = 1,
        Deleted = 2
    }

   
    public class StatusValue
    {       
        public static byte DeletedStatusID
        {
            get { return Convert.ToByte(StatusType.Deleted); }
        }        
        public static byte ActiveStatusID
        {
            get { return Convert.ToByte(StatusType.Active); }
        }
        public static byte PassiveStatusID
        {
            get { return Convert.ToByte(StatusType.Passive); }
        }
    }
}

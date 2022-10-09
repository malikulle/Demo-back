using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Enums.Sales
{
    public enum BasketStatus : byte
    {
        None = 0,
        InProgress = 1,
        Closed = 2
    }

    public static class BasketStatusValue
    {
        public static byte None
        {
            get { return Convert.ToByte(BasketStatus.None); }
        }

        public static byte InProgress
        {
            get { return Convert.ToByte(BasketStatus.InProgress); }
        }

        public static byte Closed
        {
            get { return Convert.ToByte(BasketStatus.Closed); }
        }
    }
}

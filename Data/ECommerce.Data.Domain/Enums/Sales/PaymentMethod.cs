using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Domain.Enums.Sales
{
    public enum PaymentMethod : byte
    {
        None = 0,
        EFT = 1,
        CreditCard = 2
    }

    public static class PetmendMethodValue
    {
        public static byte None
        {
            get { return Convert.ToByte(PaymentMethod.None); }
        }

        public static byte EFT
        {
            get { return Convert.ToByte(PaymentMethod.EFT); }
        }

        public static byte CreditCard
        {
            get { return Convert.ToByte(PaymentMethod.CreditCard); }
        }
    }
}

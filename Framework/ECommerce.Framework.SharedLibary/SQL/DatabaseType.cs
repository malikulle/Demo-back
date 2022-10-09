using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.SQL
{
    public static class DatabaseType
    {
        public static Database Type { get; set; }
    }

    public enum Database
    {
        SQL = 1,
        PostgreSQL = 2
    }
}

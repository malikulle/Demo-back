using Microsoft.Data.SqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.SQL
{
    public static class SQLExecution
    {
        public static object ExecuteCommand(string cmdText, object parameters)
        {
            if (DatabaseType.Type == Database.PostgreSQL)
                cmdText = ConvertToPostgre(cmdText);

            var type = parameters.GetType();
            var props = type.GetProperties().ToDictionary(op => op.Name, op => op.GetValue(parameters, null));
            if (DatabaseType.Type == Database.SQL)
                return ExecuteCommandSQL(cmdText, props);
            else
                return ExecuteCommandPostgreSQL(cmdText, props);
        }

        private static object ExecuteCommandSQL(string cmdText, Dictionary<string, object> parameters)
        {
            using (var conn = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(cmdText, (SqlConnection)conn))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            if (item.Value == null)
                                cmd.Parameters.AddWithValue("@" + item.Key, DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                        }
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        private static object ExecuteCommandPostgreSQL(string cmdText, Dictionary<string, object> parameters)
        {
            using (var conn = new NpgsqlConnection(DatabaseConnection.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(cmdText, (NpgsqlConnection)conn))
                {
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            if (item.Value == null)
                                cmd.Parameters.AddWithValue("@" + item.Key, DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                        }
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }


        private static string ConvertToPostgre(string cmdText)
        {
            cmdText = cmdText.Replace("[", "\"").Replace("]", "\"").Replace("GetDate()", "NOW()").Replace("getdate()", "NOW()");
            return cmdText;
        }
    }
}

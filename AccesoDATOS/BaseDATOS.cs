using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDATOS
{
    internal class BaseDATOS
    {
        public static string Connection
        {
            get
            {
                return ConfigurationManager.
                ConnectionStrings["NWConnection"].ConnectionString;
            }
        }

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conexion = new SqlConnection(Connection);
            conexion.Open();
            return conexion;
        }
    }


}

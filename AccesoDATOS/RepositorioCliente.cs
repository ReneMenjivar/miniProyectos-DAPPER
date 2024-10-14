using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDATOS
{
    public class RepositorioCliente
    {
        public List<Clientes> ObtenerTodo()
        {
            using (var conexion = BaseDATOS.GetSqlConnection())
            {
                String SelectALL = "";
                SelectALL = SelectALL + "SELECT [CustomerID] " + "\n";
                SelectALL = SelectALL + "      ,[CompanyName] " + "\n";
                SelectALL = SelectALL + "      ,[ContactName] " + "\n";
                SelectALL = SelectALL + "      ,[ContactTitle] " + "\n";
                SelectALL = SelectALL + "      ,[Address] " + "\n";
                SelectALL = SelectALL + "      ,[City] " + "\n";
                SelectALL = SelectALL + "      ,[Region] " + "\n";
                SelectALL = SelectALL + "      ,[PostalCode] " + "\n";
                SelectALL = SelectALL + "      ,[Country] " + "\n";
                SelectALL = SelectALL + "      ,[Phone] " + "\n";
                SelectALL = SelectALL + "      ,[Fax] " + "\n";
                SelectALL = SelectALL + "  FROM [dbo].[Customers]";

                var cliente = conexion.Query<Clientes>(SelectALL).ToList();
                return cliente;
            }
        }

    }
}

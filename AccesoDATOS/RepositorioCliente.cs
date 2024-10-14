using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public int insertarCliente(Clientes customer)
        {
            using (var conexion = BaseDATOS.GetSqlConnection())
            {
                String Insertar = "";
                Insertar = Insertar + "INSERT INTO [dbo].[Customers] " + "\n";
                Insertar = Insertar + "           ([CustomerID] " + "\n";
                Insertar = Insertar + "           ,[CompanyName] " + "\n";
                Insertar = Insertar + "           ,[ContactName] " + "\n";
                Insertar = Insertar + "           ,[ContactTitle] " + "\n";
                Insertar = Insertar + "           ,[Address]) " + "\n";
                Insertar = Insertar + "     VALUES " + "\n";
                Insertar = Insertar + "           (@customerID " + "\n";
                Insertar = Insertar + "           ,@companyName " + "\n";
                Insertar = Insertar + "           ,@contactName " + "\n";
                Insertar = Insertar + "           ,@contactTitle " + "\n";
                Insertar = Insertar + "           ,@address)";
                var insertadas = conexion.Execute(Insertar, new
                {
                    customerID = customer.CustomerID,
                    CompanyName = customer.CompanyName,
                    ContactName = customer.ContactName,
                    ContactTitle = customer.ContactTitle,
                    Address = customer.Address,
                });
                return insertadas;
            }
             

        }
        
    }
}

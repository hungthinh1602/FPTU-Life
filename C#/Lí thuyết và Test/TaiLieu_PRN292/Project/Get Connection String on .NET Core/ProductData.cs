using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MyDataService.Models
{
    public class ProductData
    {
        public string GetConnectionString()
        {
            //var appSettingsJson = AppSettingsJson.GetAppSettings();
            //var connectionString = appSettingsJson["ConnectionStrings:DefaultConnection"];
            var connectionString = "server=.;database=SaleDB;uid=sa;pwd=123";
            return connectionString; 
        }
        public IEnumerable<Product> GetProducts()
        {
            var ConnectionString = GetConnectionString();   
            List<Product> products = new List<Product>();          
            string SQLSelect = "Select * from Products";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SQLSelect,connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product p = new Product();
                        p.ProductID = reader.GetInt32(0);
                        p.ProductName = reader.GetString(1);
                        p.UnitPrice = reader.GetDouble(2);
                        p.Quantity = reader.GetInt32(3);
                        products.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return products;
        }
        public bool AddProduct(Product p)
        {
            bool result = false;
            var ConnectionString = GetConnectionString();            
            string SQLInsert= "insert Products values(@name,@price,@quantity)";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SQLInsert, connection);
            command.Parameters.AddWithValue("@name", p.ProductName);
            command.Parameters.AddWithValue("@price", p.UnitPrice);
            command.Parameters.AddWithValue("@quantity", p.Quantity);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery() > 0;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }//end insert

        public bool UpdateProduct(Product p)
        {
            bool result = false;
            var ConnectionString = GetConnectionString();
            string SQLInsert = "update Products set  ProductName = @name, UnitPrice = @price,Quantity = @quantity where ProductID = @id";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SQLInsert, connection);
            command.Parameters.AddWithValue("@id", p.ProductID);
            command.Parameters.AddWithValue("@name", p.ProductName);
            command.Parameters.AddWithValue("@price", p.UnitPrice);
            command.Parameters.AddWithValue("@quantity", p.Quantity);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }//end update

        public bool DeleteProduct(int  id)
        {
            bool result = false;
            var ConnectionString = GetConnectionString();
            string SQLInsert = "delete from Products where ProductID = @id";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SQLInsert, connection);
            command.Parameters.AddWithValue("@id", id);         
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }//end update
    }
}

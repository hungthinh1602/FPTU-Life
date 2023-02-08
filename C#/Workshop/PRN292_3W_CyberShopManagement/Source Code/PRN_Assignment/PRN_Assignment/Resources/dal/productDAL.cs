using PRN_Assignment.Resources.bll;
using PRN_Assignment.Resources.DBUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Assignment.Resources.dal
{
    class ProductDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public ProductDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllPro()
        {
            string sql = "SELECT * FROM Product";
            SqlConnection con = dc.getconnect();
            da = new SqlDataAdapter(sql,con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool addPro(Product pro)
        {
            string sql = "INSERT INTO Product(ProductID, ProductName, Brand, Price, Producer, Quantity, QuantityLeft, Description) " +
                "VALUES(@ProductID, @ProductName, @Brand, @Price, @Producer, @Quantity, @QuantityLeft, @Description)";
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ProductId", SqlDbType.NVarChar).Value = pro.ProductId;
                cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = pro.ProductName;
                cmd.Parameters.Add("@Brand", SqlDbType.NVarChar).Value = pro.Brand;
                cmd.Parameters.Add("@Price", SqlDbType.Money).Value = pro.Price;
                cmd.Parameters.Add("@Producer", SqlDbType.NVarChar).Value = pro.Producer;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = pro.Quantity;
                cmd.Parameters.Add("@QuantityLeft", SqlDbType.Int).Value = pro.QuantityLeft;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = pro.Description;
                cmd.ExecuteNonQuery();
                con.Close ();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public bool updatePro(Product pro)
        {
            string sql = "UPDATE Product " +
                "SET ProductName = @ProductName, Brand = @Brand, Producer = @Producer, Quantity = @Quantity, QuantityLeft = @QuantityLeft, Description = @Description " +
               "WHERE ProductId = @ProductId";
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar).Value = pro.ProductId;
                cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = pro.ProductName;
                cmd.Parameters.Add("@Brand", SqlDbType.NVarChar).Value = pro.Brand;
                cmd.Parameters.Add("@Producer", SqlDbType.NVarChar).Value = pro.Producer;
                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = pro.Quantity;
                cmd.Parameters.Add("@QuantityLeft", SqlDbType.Int).Value = pro.QuantityLeft;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = pro.Description;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool deletePro(Product pro)
        {
            string sql = "DELETE Product WHERE ProductId = @ProductId";
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar).Value = pro.ProductId;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable findPro(string pro)
        {
            string sql = "SELECT * FROM Product WHERE productName like N'%" + pro + "%'";
            SqlConnection conn = dc.getconnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool checkproID(string id)
        {
            string sql = "SELECT * FROM Product where " + id + " = @productid";
            SqlConnection con = dc.getconnect();
            cmd = new SqlCommand(sql, con);
            con.Open();
            
            con.Close();
            return false;
        }
    }
}

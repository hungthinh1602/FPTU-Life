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
    class OrderDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public OrderDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllOrd()
        {
            string sql = "SELECT * FROM Orders";
            SqlConnection con = dc.getconnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool addOrd(Order ord)
        {
            string sql = "INSERT INTO Orders(OrderID, ProductID, CustomerID, OrderQuantity, Price, Total) " +
                "VALUES(@OrderID, @ProductID, @CustomerID, @OrderQuantity, @Price, @Total)";
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@OrderID", SqlDbType.NVarChar).Value = ord.OrderID;
                cmd.Parameters.Add("@ProductID", SqlDbType.NVarChar).Value = ord.ProductID;
                cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = ord.CustomerID;
                cmd.Parameters.Add("@OrderQuantity", SqlDbType.Int).Value = ord.OrderQuantity;
                cmd.Parameters.Add("@Price", SqlDbType.Money).Value = ord.Price;
                cmd.Parameters.Add("@Total", SqlDbType.Int).Value = ord.Total;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
        public bool deleteOrd(Order ord)
        {
            string sql = "DELETE Orders WHERE orderid = @orderid";
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@orderid", SqlDbType.NVarChar).Value = ord.OrderID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable findOrder(string ord)
        {
            string sql = "SELECT * FROM Orders WHERE orderid like N'%" + ord + "%'";
            SqlConnection conn = dc.getconnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}

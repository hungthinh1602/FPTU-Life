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
    class customerDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public customerDAL()
        {
            dc = new DataConnection();
        }

        public DataTable getAllCus()
        {
            string sql = "SELECT * FROM Customer";
            SqlConnection con = dc.getconnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool addCus(Customer cus)
        {
            string sql = "INSERT INTO Customer(CustomerID, CustomerName, PhoneNumber, Address, Email) " +
                "VALUES(@CustomerID, @CustomerName, @PhoneNumber, @Address, @Email)";
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = cus.CustomerID;
                cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = cus.CustomerName;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = cus.PhoneNumber;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = cus.Address;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = cus.Email;
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

        public bool updateCus(Customer cus)
        {
            string sql = "UPDATE Customer " +
                "SET CustomerName = @CustomerName, PhoneNumber= @PhoneNumber, Address=@Address, Email = @Email " +
               "WHERE CustomerID = @CustomerID";
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = cus.CustomerID;
                cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = cus.CustomerName;
                cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = cus.PhoneNumber;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = cus.Address;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = cus.Email;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool deleteCus(Customer cus)
        {
            string sql = "DELETE Customer WHERE customerid = @customerid";
            SqlConnection con = dc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = cus.CustomerID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable findCus(string cus)
        {
            string sql = "SELECT * FROM customer WHERE CustomerName like N'%" + cus + "%'";
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

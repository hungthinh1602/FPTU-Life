using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ReaderApp
{
    class ReaderDAL
    {
        DBConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public ReaderDAL()
        {
            dc = new DBConnection();
        }

        public DataTable getAll ()
        {
            string sql = "SELECT * FROM readers";
            SqlConnection con = dc.Getconnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public bool Insert(Reader reader)
        {
            string sql = "INSERT INTO Readers(readerid, readername, category, dateofbirth, date, address)" +
                " VALUES(@readerid, @readername, @category, @dateofbirth, @date, @address)";
            SqlConnection con = dc.Getconnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("ReaderId", SqlDbType.NVarChar).Value = reader.ReaderID;
                cmd.Parameters.Add("ReaderName", SqlDbType.NVarChar).Value = reader.ReaderName;
                cmd.Parameters.Add("Category", SqlDbType.NVarChar).Value = reader.Category;
                cmd.Parameters.Add("DateOfBirth", SqlDbType.DateTime).Value = reader.DateOfBirth;
                cmd.Parameters.Add("Date", SqlDbType.DateTime).Value = reader.Date;
                cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = reader.Address;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Update(Reader reader)
        {
            string sql = "UPDATE Readers SET readerName = @readerName, category = @category, dateofbirth = @dateofbirth, date = @date, address = @address " +
                "WHERE readerId = @readerId";
            SqlConnection con = dc.Getconnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ReaderId", SqlDbType.NVarChar).Value = reader.ReaderID;
                cmd.Parameters.Add("@ReaderName", SqlDbType.NVarChar).Value = reader.ReaderName;
                cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = reader.Category;
                cmd.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = reader.DateOfBirth;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = reader.Date;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = reader.Address;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Delete(Reader reader)
        {
            string sql = "DALETE Readers WHERE readerId = @readerId";
            SqlConnection con = dc.Getconnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ReaderId", SqlDbType.NVarChar).Value = reader.ReaderID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}

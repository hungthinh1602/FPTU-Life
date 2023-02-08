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
    class userDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public userDAL()
        {
            dc = new DataConnection();
        }
        public bool login(string id, string pass)
        {
            int check;
            string sql = "select * from UserINFO where UserID='" + id + "' and Password='" + pass + "'";
            SqlConnection con = dc.getconnect();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, con);
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();               
                da.Fill(dt);
                check = dt.Rows.Count;
                con.Close();
                if (check == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}

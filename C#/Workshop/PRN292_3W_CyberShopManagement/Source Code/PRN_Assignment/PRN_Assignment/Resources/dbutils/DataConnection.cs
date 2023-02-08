using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PRN_Assignment.Resources.DBUtils
{
    class DataConnection
    {
        string con;
        public DataConnection()
        {
            con = ConfigurationManager.ConnectionStrings["CyberShopConnectionString"].ConnectionString;

        }
        public SqlConnection getconnect()
        {
            return new SqlConnection(con);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ReaderApp
{
    class DBConnection
    {
        /*string con = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;*/
        string con = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ConnectionString;

        public SqlConnection Getconnection()
        {
            return new SqlConnection(con);
        }
    }
}

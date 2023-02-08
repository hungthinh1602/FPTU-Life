using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Class1
/// </summary>
public class DBNews
{
	public DBNews()
	{
	}

    public static DataTable GetNews()
    {
        string strConnection = GetConnectionString();
        string SQL = "Select * from BanTin";
        OleDbDataAdapter da = new OleDbDataAdapter(SQL, strConnection);
        DataTable dtNews = new DataTable();
        da.Fill(dtNews);
        return dtNews;
    }

    public static string GetConnectionString()
    {
        return WebConfigurationManager.ConnectionStrings["News"].ConnectionString;
    }
}

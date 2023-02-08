using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class TestDataCache : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            LoadData();
        }
    }
    private void LoadData() {
        DataTable dtPro = Cache["ProductData"] 
            as DataTable;
        if (dtPro == null) {
            dtPro = GetProducts();
            //Cache["ProductData"] = dtPro;

            //su dung thoi gian tuyet doi
            //Cache.Insert("ProductData", dtPro, null,DateTime.Now.AddSeconds(120),
            //    System.Web.Caching.Cache.NoSlidingExpiration);
            
            //su dung thoi gian tuong doi            
            Cache.Insert("ProductData", dtPro, null, 
                System.Web.Caching.Cache.NoAbsoluteExpiration, 
            TimeSpan.FromSeconds(10));
            
            lbMsg.Text = "Data get from database";
        }
        else {
            lbMsg.Text = "Data get from cache";
        }
        gvProduct.DataSource = dtPro;
        gvProduct.DataBind();
    }
    private DataTable GetProducts() {
      string strConnection = "server=.;database=northwind;uid=sa;pwd=123";
      string SQL = "select  ProductID,ProductName,UnitPrice from Products";
      SqlDataAdapter da = new SqlDataAdapter(SQL, strConnection);
      DataTable dtPro = new DataTable();
      da.Fill(dtPro);
      //da.SelectCommand.Connection.Close();
      return dtPro;
    }
    protected void gvProduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvProduct.PageIndex = e.NewPageIndex;
        LoadData();
    }
}
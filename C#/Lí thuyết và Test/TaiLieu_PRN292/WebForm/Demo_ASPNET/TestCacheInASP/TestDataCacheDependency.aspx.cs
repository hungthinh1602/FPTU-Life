using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Caching;
public partial class TestDataCache : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            LoadData();
        }
    }
    private void LoadData() {
        DataTable dtPro = Cache["ProductData"] as DataTable;
        if (dtPro == null) {
            dtPro = GetProducts();
            //1. Them vao SQlCacheDependency
         SqlCacheDependency scd = 
             new SqlCacheDependency("NorthWind", "Products");
                        
            Cache.Insert("ProductData", dtPro, scd, DateTime.Now
                .AddSeconds(120), TimeSpan.Zero);
  
            lbMsg.Text = "Data get from database";
        }
        else {
            lbMsg.Text = "Data get from cache";
        }
        gvProduct.DataSource = dtPro;
        gvProduct.DataBind();
    }
    private DataTable GetProducts() {
      string strConnection = System.Web.Configuration.WebConfigurationManager
          .ConnectionStrings["NorthWindDB"].ConnectionString;
      string SQL = "select  ProductID,ProductName,UnitPrice from Products";
      SqlDataAdapter da = new SqlDataAdapter(SQL, strConnection);
      DataTable dtPro = new DataTable();
      da.Fill(dtPro);
      return dtPro;
    }
    protected void gvProduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvProduct.PageIndex = e.NewPageIndex;
        LoadData();
    }
}
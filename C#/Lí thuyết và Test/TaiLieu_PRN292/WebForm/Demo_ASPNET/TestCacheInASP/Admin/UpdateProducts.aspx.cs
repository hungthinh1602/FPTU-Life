using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;
using System.Web.Configuration;
public partial class Admin_UpdateProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {      

    }
    protected void btnEnableCache_Click(object sender, EventArgs e)
    {
        string strConnection = WebConfigurationManager
        .ConnectionStrings["NorthWindDB"].ConnectionString;
        SqlCacheDependencyAdmin.EnableNotifications(strConnection);
        SqlCacheDependencyAdmin.EnableTableForNotifications
            (strConnection, "Products");
    }
}
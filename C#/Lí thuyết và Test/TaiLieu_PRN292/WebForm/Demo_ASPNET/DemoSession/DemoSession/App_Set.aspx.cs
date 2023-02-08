using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class App_Set : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Khai bao 1 bien application
        Application.Lock();
        Application["SoNguoiTruyCap"] = 100;        
        //////hoac 
        Application.Add("UserName", "Tom");
        Application.UnLock();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("App_Get.aspx");
    }
}

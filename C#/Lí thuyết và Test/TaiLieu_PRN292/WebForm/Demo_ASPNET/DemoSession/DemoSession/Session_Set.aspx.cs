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

public partial class Session_Set : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false){
            Response.Write(Session.SessionID + "<br>");
            //Session.Timeout = 1;//phut
            //Response.Write(Session.Timeout.ToString() + "<br>");

            //Khai bao bien session ten la "UserName" luu gia tri "tom"
            //bien session co the luu cac gia tri co kieu bat ky
            // int, string , array, list,....
            Session["UserName"] = "tom";
            //
            //Session.Add("abc", 1234);

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Session_Get.aspx");
    }
}

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

public partial class Session_Get : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       Response.Write(Session.SessionID+"<br>");

       if (Session["UserName"] != null)
           Response.Write(Session["UserName"].ToString());
       else
           Response.Write("session khong ton tai .");
    }
}

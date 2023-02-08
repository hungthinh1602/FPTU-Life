using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class TestCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        HttpCookie ck = new HttpCookie("myweb.com");
        ck["Ten"] = "Tomy";
        ck.Expires = DateTime.Now.AddSeconds(15);
        Response.Cookies.Add(ck);
    }
    protected void btnRead_Click(object sender, EventArgs e)
    {
        HttpCookie ck = Request.Cookies["myweb.com"];
        if (ck != null)
        {
            Response.Write(ck["Ten"]);
            //xoa Cookie
            //ck.Expires = DateTime.Now.AddDays(-1);
            //Response.Cookies.Add(ck);
        }
        else {
            Response.Write("Cookie ....");
        }
    }
}

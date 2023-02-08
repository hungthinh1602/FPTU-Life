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

public partial class P_Cookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {        
        HttpCookie ck = new HttpCookie("www.myweb.com");
        ck["TenDangNhap"] = TextBox1.Text;
        ck.Expires = DateTime.Now.AddSeconds(10);
        Response.Cookies.Add(ck);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        HttpCookie ck = Request.Cookies["www.myweb.com"];
        if (ck != null){
            Response.Write(ck["TenDangNhap"]);
        }
        else {
            Response.Write("Cookie khong ton tai.");
        }
    }
}

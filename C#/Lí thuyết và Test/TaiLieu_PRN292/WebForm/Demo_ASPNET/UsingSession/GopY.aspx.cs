using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GopY : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie ck = Request.Cookies["www.myweb.com"];

        if (Session["TenNguoiDung"] != null)
            Label1.Text = "Xin  chao :" +
                Session["TenNguoiDung"].ToString();
        else if (ck == null)
            Response.Redirect("DangNhap.aspx");
        else
            Label1.Text ="Xin  chao :"+ck["TenDangNhap"];
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        //huy cac bien session
        Session.Abandon();

        HttpCookie ck = Request.Cookies["www.myweb.com"];
        if (ck != null)
        {
            //xoa Cookie
            ck.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(ck);
        }
        Response.Redirect("~/DangNhap.aspx");
    }
}

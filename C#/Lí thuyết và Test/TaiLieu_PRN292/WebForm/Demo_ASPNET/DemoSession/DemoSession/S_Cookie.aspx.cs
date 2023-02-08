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

public partial class S_Cookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Cookies["www.myweb.com"]["UserName"] = TextBox1.Text;        
        Response.Cookies["www.myweb.com"].Expires = 
            DateTime.Now.AddSeconds(15);
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["www.myweb.com"] == null)
        {
            Response.Write("Cookie is null");
        }
        else
        {
            string s = Request.Cookies["www.myweb.com"]["UserName"];
            Response.Write(s);
        }
    }
}

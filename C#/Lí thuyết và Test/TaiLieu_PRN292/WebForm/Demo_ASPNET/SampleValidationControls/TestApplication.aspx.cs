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

public partial class TestApplication : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        Application["NumberOne"] = 100;
        Application["MyData"] = "Hello";
    }
    protected void btnRead_Click(object sender, EventArgs e)
    {
        int n = (int)Application["NumberOne"];
        string s = Application["MyData"].ToString();

        Response.Write(n+" , "+s);
    }
}

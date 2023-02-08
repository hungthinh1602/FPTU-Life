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

public partial class TestHTML : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //HtmlInputText t = new HtmlInputText();
        //t.Value = "AAAA";
        //Page.Controls.Add(t);

        //Response.Write("<input ....>");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Response.Write("asas");
        }
    }
}

<%@ Application Language="C#" %>
<%@ Import Namespace="System.Data" %>
<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        //Khai bao gio hang
        DataTable dtCart = new DataTable();
        dtCart.Columns.Add("MaHH",typeof(int));
        dtCart.Columns.Add("TenHH",typeof(string));
        dtCart.Columns.Add("DonGia",typeof(float));
        dtCart.Columns.Add("SoLuong",typeof(int));
        dtCart.Columns["SoLuong"].DefaultValue = 1;
        dtCart.Columns.Add("ThanhTien",typeof(float),
            "SoLuong*DonGia");
        //Thiet lap khoa chinh cho gio hang
        dtCart.PrimaryKey = new DataColumn[]
        {dtCart.Columns[0] };
        Session["GioHang"] = dtCart;
    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>

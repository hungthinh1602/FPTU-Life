<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestDataCacheDependency.aspx.cs" Inherits="TestDataCache" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvProduct" runat="server" AllowPaging="True" 
            BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
            CellPadding="4" EnableModelValidation="True" 
            onpageindexchanging="gvProduct_PageIndexChanging" PageSize="5">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        </asp:GridView>
        <br />
        <asp:Label ID="lbMsg" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>

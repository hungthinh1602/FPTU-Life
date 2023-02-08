<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestCustom.aspx.cs" Inherits="TestCustom" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="khong phai so chan" 
            onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>

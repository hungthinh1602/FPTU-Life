<%@ Page Language="C#" AutoEventWireup="true" Trace="false"  CodeFile="P_Cookie.aspx.cs" Inherits="P_Cookie" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter a string<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" />&nbsp;<asp:Button
            ID="Button2" runat="server"  Text="Get Value" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>

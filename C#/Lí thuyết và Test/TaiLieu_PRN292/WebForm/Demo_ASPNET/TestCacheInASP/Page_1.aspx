<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page_1.aspx.cs" Inherits="Page_1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="17px" Width="113px">
        <asp:ListItem Text="Red" Value="Red" />
        <asp:ListItem Text="Green" Value="Green" />
        <asp:ListItem Text="Blue" Value="Blue" />
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            onclick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>

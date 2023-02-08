<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Range.aspx.cs" Inherits="Range" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="Age >=18 and <=100" MaximumValue="100" MinimumValue="18" Type="Integer" ValidationGroup="A"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="RequiredFieldValidator" ValidationGroup="A"></asp:RequiredFieldValidator><br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="A" /></div>
    </form>
</body>
</html>

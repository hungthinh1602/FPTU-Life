<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestHTML.aspx.cs" Inherits="TestHTML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="Ten dang nhap khong bo trong">*</asp:RequiredFieldValidator><br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" /><br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
       
    </div>
    </form>
</body>
</html>

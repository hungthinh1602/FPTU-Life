<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Compare.aspx.cs" Inherits="Compare" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="CompareValidator" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="18" ValidationGroup="ValueToCompare">*</asp:CompareValidator><br />
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBox2"
            ControlToValidate="TextBox3" ErrorMessage="Password invalid"></asp:CompareValidator><br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Test Compare to Value" ValidationGroup="ValueToCompare" Width="170px" />
        <asp:Button ID="Button2" runat="server" Text="Test Compare TextBox" Width="181px" /><br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
            ValidationGroup="ValueToCompare" />
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Require.aspx.cs" Inherits="_Default" %>

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
            ErrorMessage="User name not  blank !">*</asp:RequiredFieldValidator><br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" DataSourceID="SqlDataSource1"
            DataTextField="ProductName" DataValueField="ProductID" Width="182px">
            <asp:ListItem>--Select a product--</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1"
            ErrorMessage="You must select a product" InitialValue="--Select a product--">*</asp:RequiredFieldValidator>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
            SelectCommand="SELECT [ProductID], [ProductName] FROM [Products]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" /><br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    
    </div>
    </form>
</body>
</html>

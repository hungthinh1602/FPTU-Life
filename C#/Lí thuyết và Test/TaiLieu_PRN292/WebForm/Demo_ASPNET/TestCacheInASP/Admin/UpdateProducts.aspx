<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateProducts.aspx.cs" Inherits="Admin_UpdateProducts" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Products</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" 
            EnableModelValidation="True" AllowPaging="True" 
            AutoGenerateColumns="False" PageSize="3" DataKeyNames="ProductID">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                    InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" 
                    SortExpression="ProductName" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" 
                    SortExpression="UnitPrice" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" 
            ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" 
            DeleteCommand="DELETE FROM [Products] WHERE [ProductID] = @original_ProductID AND [ProductName] = @original_ProductName AND (([UnitPrice] = @original_UnitPrice) OR ([UnitPrice] IS NULL AND @original_UnitPrice IS NULL))" 
            InsertCommand="INSERT INTO [Products] ([ProductName], [UnitPrice]) VALUES (@ProductName, @UnitPrice)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice] FROM [Products]" 
            
            UpdateCommand="UPDATE [Products] SET [ProductName] = @ProductName, [UnitPrice] = @UnitPrice WHERE [ProductID] = @original_ProductID AND [ProductName] = @original_ProductName AND (([UnitPrice] = @original_UnitPrice) OR ([UnitPrice] IS NULL AND @original_UnitPrice IS NULL))" 
            CacheDuration="30" SqlCacheDependency="NorthWind:Products">
            <DeleteParameters>
                <asp:Parameter Name="original_ProductID" Type="Int32" />
                <asp:Parameter Name="original_ProductName" Type="String" />
                <asp:Parameter Name="original_UnitPrice" Type="Decimal" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ProductName" Type="String" />
                <asp:Parameter Name="UnitPrice" Type="Decimal" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ProductName" Type="String" />
                <asp:Parameter Name="UnitPrice" Type="Decimal" />
                <asp:Parameter Name="original_ProductID" Type="Int32" />
                <asp:Parameter Name="original_ProductName" Type="String" />
                <asp:Parameter Name="original_UnitPrice" Type="Decimal" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    <asp:Button ID="btnEnableCache" runat="server" onclick="btnEnableCache_Click" 
        Text="Create Dependency" />
    </form>
</body>
</html>

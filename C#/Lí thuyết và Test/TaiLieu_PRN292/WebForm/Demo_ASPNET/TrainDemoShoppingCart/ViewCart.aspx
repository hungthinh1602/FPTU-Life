<%@ Page Language="C#" AutoEventWireup="true"
    
     CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    
        <asp:GridView ID="gvShoppingCart"
            DataKeyNames="MaHH"
             ShowFooter ="True" AutoGenerateColumns="False"
             runat="server" OnRowCancelingEdit="gvShoppingCart_RowCancelingEdit" OnRowDeleting="gvShoppingCart_RowDeleting" OnRowEditing="gvShoppingCart_RowEditing" OnRowUpdating="gvShoppingCart_RowUpdating">
         <Columns>
              <asp:BoundField HeaderText="Ma Mat Hang"
                   ReadOnly="true"
                   DataField="MaHH"/>
               <asp:BoundField HeaderText="Ten Mat Hang"
                   ReadOnly="true"
                   DataField="TenHH"/>
               <asp:BoundField HeaderText="Don gia"
                   ReadOnly="true" DataFormatString="{0:c}"
                   DataField="DonGia"/>
               <asp:TemplateField HeaderText="So Luong">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtSoLuong" runat="server" Text='<%# Bind("SoLuong") %>'></asp:TextBox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSoLuong" Display="Dynamic" ErrorMessage="So luong khong bo trong" ForeColor="Red">*</asp:RequiredFieldValidator>
                       <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSoLuong" ErrorMessage="So luong tu 1 den 10" ForeColor="Red" MaximumValue="10" MinimumValue="1" Type="Integer">*</asp:RangeValidator>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label1" runat="server" Text='<%# Bind("SoLuong") %>'></asp:Label>
                   </ItemTemplate>
              </asp:TemplateField>
               <asp:BoundField HeaderText="Thanh Tien"
                   ReadOnly="true"
                   DataField="ThanhTien"/>
               
              <asp:CommandField CancelText="Huy" EditText="Sua" ShowEditButton="True" UpdateText="Dong Y" />
              <asp:CommandField DeleteText="Xoa" ShowDeleteButton="True" />
               
         </Columns>
        </asp:GridView>
    
    </div>
        <asp:Button ID="btnDatHang" runat="server" OnClick="btnDatHang_Click" Text="Dat Hang" />
    </form>
</body>
</html>

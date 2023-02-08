<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="imgBtnXemGioHang" runat="server" Height="31px" ImageUrl="~/Hinh/icons/Basket.png" OnClick="imgBtnXemGioHang_Click" Width="43px" />
        <br />
    
        <asp:DataList ID="dlProducts"
             RepeatColumns="3"
             runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnItemCommand="dlProducts_ItemCommand">
            <AlternatingItemStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHH") %>'></asp:Label>
                <br />
                <asp:Image ID="Image1" runat="server" Height="88px" ImageUrl='<%# Eval("Hinh","~/Hinh/HangHoa/{0}") %>' Width="119px" />
                <br />
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia","{0:C}") %>'></asp:Label>
                <br />
                <asp:ImageButton ID="imgAddToCart" 
                    ImageUrl="~/Hinh/icons/Add to basket.png"
                    CommandName="ThemGioHang"
                    CommandArgument='<%# Eval("MaHH")+";"+
                    Eval("TenHH")+";"+Eval("DonGia")%>'
                    runat="server" />                
                 
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>

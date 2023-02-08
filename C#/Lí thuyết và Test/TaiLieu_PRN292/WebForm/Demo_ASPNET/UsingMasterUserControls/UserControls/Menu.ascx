<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="Menu" %>
<P>
	<asp:HyperLink id="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Visible="False">Trang chủ</asp:HyperLink><BR>
	<asp:HyperLink id="HyperLink2" runat="server" NavigateUrl="~/Xahoi.aspx">Xã hội</asp:HyperLink><BR>
	<asp:HyperLink id="HyperLink3" runat="server">Kinh tế</asp:HyperLink><BR>
	<asp:HyperLink id="HyperLink4" runat="server">Thể thao</asp:HyperLink><BR>
	<BR>
	<asp:AdRotator id="AdRotator1" runat="server" Width="133px" Height="58px" AdvertisementFile="ads.xml"></asp:AdRotator>
</P>

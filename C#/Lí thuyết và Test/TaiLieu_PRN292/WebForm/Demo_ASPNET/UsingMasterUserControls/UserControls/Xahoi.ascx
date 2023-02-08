<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Xahoi.ascx.cs" Inherits="Xahoi" %>
<asp:datalist id=dataListTomTatTinTuc  DataKeyField ="MaBanTin" DataMember="BANTIN"  runat="server">
	<ItemTemplate>
		<TABLE id="Table9" cellSpacing="3" cellPadding="3" width="100%" border="0">
			<TR>
				<TD colSpan="2">
					<asp:HyperLink id="HyperLink1" runat="server" Font-Size="Medium" BackColor ="#3399ff" Font-Bold="True" ForeColor="Maroon" Text='<%# Eval("TieuDe") %>'>
					</asp:HyperLink><BR>
					<asp:Label id="Label2" runat="server" Font-Size="Medium" ForeColor="DimGray" Text='<%# DataBinder.Eval(Container, "DataItem.NgayDangTin") %>'>
					</asp:Label></TD>
			</TR>
			<TR>
				<TD>
					<asp:Image id="Image1" runat="server" ImageUrl='<%# Eval("HinhAnh") %>'>
					</asp:Image></TD>
				<TD vAlign="top">
					<asp:Label id="Label1" runat="server" Font-Size="Medium" Text='<%# Eval("NoiDungTomTat") %>'>
					</asp:Label></TD>
			</TR>
		</TABLE>
	</ItemTemplate>
</asp:datalist>
&nbsp;
<BR>
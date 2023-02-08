<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Ads.ascx.cs" Inherits="Ads" %>
<marquee bgcolor="#ffffcc" width="178" height="200" direction="up" scrollamount="2" onmouseover="this.stop()"
	onmouseout="this.start()" style="WIDTH: 178px; HEIGHT: 200px">
	<table width="100%" cellpadding="0" cellspacing="0">
		<tr>
			<td align="center">
				<a href='giaitri.aspx'><img height="80" src="UserControls\images\ImageView1.jpg" border="0"> </a>
			</td>
		</tr>
		<tr>
			<td align="center">
				Phim trong tuần
			</td>
		</tr>
		<tr>
			<td height="30">
			</td>
		</tr>
	</table>
</marquee>
<P>
	<asp:Image id="Image1" runat="server" ImageUrl="images\Image1.gif"></asp:Image><BR>
	<asp:Image id="Image2" runat="server" ImageUrl="images\image2.gif"></asp:Image><BR>
</P>

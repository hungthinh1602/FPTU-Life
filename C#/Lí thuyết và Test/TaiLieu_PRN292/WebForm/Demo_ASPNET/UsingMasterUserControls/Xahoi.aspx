<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Xahoi.aspx.cs" Inherits="Xahoi" Title="Untitled Page" %>

<%@ Register Src="UserControls\Xahoi.ascx" TagName="Xahoi" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:Xahoi ID="Xahoi1" runat="server" />
</asp:Content>


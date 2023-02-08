<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TinTuc.aspx.cs" Inherits="UserControls_TinTuc" %>

<%@ Register src="Xahoi.ascx" tagname="Xahoi" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:Xahoi ID="Xahoi1" runat="server" />
</asp:Content>


﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestCookie.aspx.cs" Inherits="TestCookie" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnCreate" runat="server" Text="Create" 
            onclick="btnCreate_Click" Height="17px" style="height: 27px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRead" runat="server" Text="Read" onclick="btnRead_Click" />
    
    </div>
    </form>
</body>
</html>

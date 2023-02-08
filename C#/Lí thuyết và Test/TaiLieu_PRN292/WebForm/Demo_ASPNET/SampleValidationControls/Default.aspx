<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" Culture="Auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript"  type="text/javascript">
        function Check() {
            var us = document.getElementById('txtUserName');
            var pwd = document.getElementById('txtPassword');
            if (us.value == '' || pwd.value == '') {
                alert('user name or password not blank !');
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <br />
        User name :
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtUserName" ErrorMessage="User name not blank" 
            SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <br />
        Password&nbsp; :
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtPassword" ErrorMessage="Password ...." 
            SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <br />
        Confirm password
        <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="txtConfirmPassword" Display="Dynamic" 
            ErrorMessage="Confirm password ...">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" 
            ErrorMessage="Password invalid">*</asp:CompareValidator>
        <br />
        Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="txtAge" ErrorMessage="Age invalid" MaximumValue="100" 
            MinimumValue="18" SetFocusOnError="True" Type="Integer">*</asp:RangeValidator>
        <br />
        Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtEmail" ErrorMessage="Email invalid" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="btnRegister"   runat="server" Text="Registry" 
            onclick="btnLogin_Click"  />
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="28px" 
            Text="Clear" CausesValidation="False" />
    
        <br />
    
    </div>
        
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <br />
        
    </form>
</body>
</html>

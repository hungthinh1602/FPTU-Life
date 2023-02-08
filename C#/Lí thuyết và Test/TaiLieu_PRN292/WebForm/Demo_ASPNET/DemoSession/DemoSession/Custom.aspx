<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Custom.aspx.cs" Inherits="Custom" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>   
  <script type="text/javascript" language="JavaScript">
       function KiemTra(oSrc, args) {
           var n = parseInt(args.Value);
           //if (n % 2 == 0)
           //    args.IsValid = true;
           //else
           //     args.IsValid = false;
                args.IsValid = (n%2==0);
       }
</script>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
        ClientValidationFunction="KiemTra"
            ControlToValidate="TextBox1" ErrorMessage="n la so le" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></div>
    </form>
</body>
</html>

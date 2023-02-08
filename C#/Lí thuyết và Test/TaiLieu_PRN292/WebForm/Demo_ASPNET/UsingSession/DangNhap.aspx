<%@ Page Language="C#"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
             
        if(txtTenDangNhap.Text == "a" &&
            txtMatKhau.Text=="a")  {
            if (chkLuuThongTinDangNhap.Checked) {
                HttpCookie ck = new HttpCookie("www.myweb.com");
                ck["TenDangNhap"] = txtTenDangNhap.Text;
                ck.Expires = DateTime.Now.AddMinutes(30);
                Response.Cookies.Add(ck); 
            }
            Session["TenNguoiDung"] = txtTenDangNhap.Text;
            Response.Redirect("Gopy.aspx");
        }
    }
    protected void Page_Load(object sender, EventArgs e) {               
        HttpCookie ck = Request.Cookies["www.myweb.com"];            
        if(ck!=null)
            Response.Redirect("GopY.aspx");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Đăng nhập</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Tên đăng nhập :
        <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
        <br />
        Mật khẩu&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkLuuThongTinDangNhap" runat="server" 
            Text="Nhớ  thông tin này để truy cập lần sau" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" 
            onclick="btnDangNhap_Click" />
    
    </div>
    </form>
</body>
</html>

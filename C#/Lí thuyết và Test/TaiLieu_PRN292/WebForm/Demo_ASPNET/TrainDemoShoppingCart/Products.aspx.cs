using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            LoadData();
        }
    }
    private void LoadData(){
        DataTable dtHangHoa = GetProducts();
        dlProducts.DataSource = dtHangHoa;
        dlProducts.DataBind();
    }
    public DataTable GetProducts() {
        string chuoiKetNoi = "server=.;database=eStore20;uid=sa;pwd=123";
        string cauLenhSQL = "select MaHH,TenHH,DonGia,Hinh from  HangHoa";
        SqlDataAdapter da = new SqlDataAdapter(cauLenhSQL, chuoiKetNoi);
        DataTable dtPro = new DataTable();
        da.Fill(dtPro);
        return dtPro;
    }
    protected void dlProducts_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("ThemGioHang"))
        {
            string data = e.CommandArgument.ToString();
            string[] danhsachThamSo = data.Split(';');
            int MaHH = int.Parse(danhsachThamSo[0]);
            string TenHH = danhsachThamSo[1];
            float DonGia = float.Parse(danhsachThamSo[2]);
            //1.lay gio hang tu Session
            DataTable dtCart = Session["GioHang"] as DataTable;
            //2. Tim mat hang da co trong gio hay chua ?
            DataRow rMatHang = dtCart.Rows.Find(MaHH);
            if (rMatHang == null) {
                dtCart.Rows.Add(MaHH, TenHH, DonGia);
            }
            else {
                rMatHang["SoLuong"] =
                    (int)rMatHang["SoLuong"] + 1;
            }
        }
    }
    protected void imgBtnXemGioHang_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/ViewCart.aspx");
    }
}
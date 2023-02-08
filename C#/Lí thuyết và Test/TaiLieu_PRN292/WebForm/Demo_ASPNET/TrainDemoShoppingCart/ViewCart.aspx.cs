using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            LoadCart();
        }
    }
    public void LoadCart() {
        DataTable dtCart = Session["GioHang"] as DataTable;
        gvShoppingCart.DataSource = dtCart;
        gvShoppingCart.DataBind();
        gvShoppingCart.FooterRow.Cells[3].Text = "Tong Tien";
        gvShoppingCart.FooterRow.Cells[4].Text =
            dtCart.Compute("SUM(ThanhTien)","").ToString();
    }
    protected void gvShoppingCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int MaHH = (int)gvShoppingCart.DataKeys
           [e.RowIndex].Value;
        DataTable dtCart = Session["GioHang"] as DataTable;
        DataRow rMatHang = dtCart.Rows.Find(MaHH);
        rMatHang.Delete();
        LoadCart();
    }
    protected void gvShoppingCart_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvShoppingCart.EditIndex = e.NewEditIndex;
        LoadCart();
    }
    protected void gvShoppingCart_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //lay MaHH
        int MaHH = (int)gvShoppingCart.DataKeys
            [e.RowIndex].Value;
        //lay So Luong
        TextBox txtSoLuong = gvShoppingCart.Rows[e.RowIndex]
            .Cells[3].FindControl("txtSoLuong") as TextBox;
        DataTable dtCart = Session["GioHang"] as DataTable;
        DataRow rMatHang = dtCart.Rows.Find(MaHH);
        rMatHang["SoLuong"] =            
                int.Parse(txtSoLuong.Text);
        gvShoppingCart.EditIndex = -1;
        LoadCart();
    }
    protected void gvShoppingCart_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvShoppingCart.EditIndex = -1;
        LoadCart();
    }
    protected void btnDatHang_Click(object sender, EventArgs e)
    {
        //Them du lieu trong datatable dtCart vao DB
        DataTable dtCart = Session["GioHang"] as DataTable;
        //goi ham ThemHoaDon(MaHD,MaKH,NgayDatHang,..)
        foreach (DataRow matHang in dtCart.Rows)
        {
            int MaMH = (int)matHang["MaMH"];         
            float DonGia = (float)matHang["DonGia"];
            int SoLuong = (int)matHang["SoLuong"];
            //goi ham ThemChiTietHoaDon(MaHD,MaMH,SoLuong,DonGia);
            

        }
    }
}
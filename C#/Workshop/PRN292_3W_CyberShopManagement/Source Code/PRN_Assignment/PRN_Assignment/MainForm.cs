using PRN_Assignment.Resources.bll;
using PRN_Assignment.Resources.DBUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_Assignment
{
    public partial class MainForm : Form
    {
        ProductBLL proCtr;
        CustomerBLL cusCtr;
        OrderBLL orderCtr;
        public MainForm()
        {
            InitializeComponent();
            proCtr = new ProductBLL();
            cusCtr = new CustomerBLL();
            orderCtr = new OrderBLL();
        }

        public void showAllPro()
        {
            DataTable dt = proCtr.getAllPro();
            dgv_dssp.DataSource = dt;
            
        }
        public void showAllOrd()
        {
            DataTable dt = orderCtr.getAllOrd();
            dgv_dsdh.DataSource = dt;

        }
        private bool checkDataPro()
        {
            if (string.IsNullOrEmpty(txt_tensp.Text))
            {
                MessageBox.Show("Chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensp.Focus();                
                return false;
            }
            if (string.IsNullOrEmpty(txt_masp.Text))
            {
                MessageBox.Show("Chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_masp.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_giasp.Text))
            {
                MessageBox.Show("Chưa nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_giasp.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_loaisp.Text))
            {
                MessageBox.Show("Chưa nhập hãng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_loaisp.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_nhasx.Text))
            {
                MessageBox.Show("Chưa nhập nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_nhasx.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_soluongsp.Text))
            {
                MessageBox.Show("Chưa nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_soluongsp.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_spconlai.Text))
            {
                MessageBox.Show("Chưa nhập sản phẩm còn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_spconlai.Focus();
                return false;
            }
            return true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            showAllPro();
            showAllCus();
            showAllOrd();
            this.Hide();
        }

        private void tab_sanpham_Click(object sender, EventArgs e)
        {

        }

        
        private void btn_themsp_Click(object sender, EventArgs e)
        {
            if (checkDataPro())
            {
                string id = txt_masp.Text;
                Product pro = new Product();  
                pro.ProductId = txt_masp.Text;  
                pro.ProductName = txt_tensp.Text;
                pro.Brand = txt_loaisp.Text;
                pro.Price = decimal.Parse(txt_giasp.Text);
                pro.Producer = txt_nhasx.Text;
                pro.Quantity = int.Parse(txt_soluongsp.Text);
                pro.QuantityLeft = int.Parse(txt_spconlai.Text);
                pro.Description = txt_motasp.Text;

                    if (proCtr.addPro(pro))
                    {
                        showAllPro();
                    }
                 
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgv_dssp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_masp.Enabled = false;
            int index = e.RowIndex;
            txt_masp.Text = dgv_dssp.Rows[index].Cells["ProductID"].Value.ToString();
            txt_tensp.Text = dgv_dssp.Rows[index].Cells["ProductName"].Value.ToString();
            txt_soluongsp.Text = dgv_dssp.Rows[index].Cells["Quantity"].Value.ToString();
            txt_nhasx.Text = dgv_dssp.Rows[index].Cells["Producer"].Value.ToString();
            txt_loaisp.Text = dgv_dssp.Rows[index].Cells["Brand"].Value.ToString();
            txt_giasp.Text = dgv_dssp.Rows[index].Cells["Price"].Value.ToString();
            txt_motasp.Text = dgv_dssp.Rows[index].Cells["Description"].Value.ToString();
            txt_spconlai.Text = dgv_dssp.Rows[index].Cells["QuantityLeft"].Value.ToString();            
        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Product pr = new Product();
                    pr.ProductId = txt_masp.Text;
                    if (proCtr.deletePro(pr))
                    {
                        showAllPro();
                        txt_masp.Enabled = true;
                        txt_masp.Text = "";
                        txt_tensp.Text = "";
                        txt_loaisp.Text = "";
                        txt_motasp.Text = "";
                        txt_spconlai.Text = "";
                        txt_soluongsp.Text = "";
                        txt_nhasx.Text = "";
                        txt_giasp.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
   
        }

        private void txt_timkiemsp_TextChanged(object sender, EventArgs e)
        {
            string value = txt_timkiemsp.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = proCtr.findPro(value);
                dgv_dssp.DataSource = dt;
            }
            else
            {
                showAllPro();
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {

            txt_masp.Enabled = true;
            txt_masp.Text = "";
            txt_tensp.Text = "";
            txt_loaisp.Text = "";
            txt_motasp.Text = "";
            txt_spconlai.Text = "";
            txt_soluongsp.Text = "";
            txt_nhasx.Text = "";
            txt_giasp.Text = "";
        }

        private void btn_suathongtin_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.ProductId = txt_masp.Text;
            pro.ProductName = txt_tensp.Text;
            pro.Brand = txt_loaisp.Text;
            pro.Price = decimal.Parse(txt_giasp.Text);            
            pro.Producer = txt_nhasx.Text;
            pro.Quantity = int.Parse(txt_soluongsp.Text);
            pro.QuantityLeft = int.Parse(txt_spconlai.Text);
            pro.Description = txt_motasp.Text;
            if (proCtr.updatePro(pro))
            {
                showAllPro();                
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showAllCus()
        {
            DataTable dt = cusCtr.getAllCus();
            dgv_dskh.DataSource = dt;
        }
        public bool checkDataCus()
        {
            if (string.IsNullOrEmpty(txt_makh.Text))
            {
                MessageBox.Show("Chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_tenkh.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenkh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_sdtkh.Text))
            {
                MessageBox.Show("Chưa nhập sđt khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdtkh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_diachikh.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachikh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_emailkh.Text))
            {
                MessageBox.Show("Chưa nhập email khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_emailkh.Focus();
                return false;
            }

            return true;
        }
        private void btn_themkh_Click(object sender, EventArgs e)
        {
            if (checkDataCus())
            {
                Customer cus = new Customer();
                cus.CustomerID = txt_makh.Text;
                cus.CustomerName = txt_tenkh.Text;
                cus.PhoneNumber = txt_sdtkh.Text;
                cus.Address = txt_diachikh.Text;
                cus.Email = txt_emailkh.Text;
                if (cusCtr.addCus(cus))
                {
                    showAllCus();
                }
                else
                {
                    MessageBox.Show("Không thêm được khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btn_suakh_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.CustomerID = txt_makh.Text;
            cus.CustomerName = txt_tenkh.Text;
            cus.PhoneNumber = txt_sdtkh.Text;
            cus.Address = txt_diachikh.Text;
            cus.Email = txt_emailkh.Text;
            if (cusCtr.updateCus(cus))
            {
                showAllCus();
            }
            else
            {
                MessageBox.Show("Không sửa được thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_dskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Enabled = false;
            int index = e.RowIndex;
            txt_makh.Text = dgv_dskh.Rows[index].Cells["CustomerID"].Value.ToString();
            txt_tenkh.Text = dgv_dskh.Rows[index].Cells["CustomerName"].Value.ToString();
            txt_sdtkh.Text = dgv_dskh.Rows[index].Cells["PhoneNumber"].Value.ToString();
            txt_diachikh.Text = dgv_dskh.Rows[index].Cells["Address"].Value.ToString();
            txt_emailkh.Text = dgv_dskh.Rows[index].Cells["Email"].Value.ToString();
        }

        private void btn_xoakh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Customer cus = new Customer();
                cus.CustomerID = txt_makh.Text;
                if (cusCtr.deleteCus(cus))
                {
                    showAllCus();
                    txt_makh.Text = "";
                    txt_tenkh.Text = "";
                    txt_sdtkh.Text = "";
                    txt_diachikh.Text = "";
                    txt_emailkh.Text = "";
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txt_timkiemkh_TextChanged(object sender, EventArgs e)
        {
            string value = txt_timkiemkh.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = cusCtr.findCus(value);
                dgv_dskh.DataSource = dt;
            }
            else
            {
                showAllCus();
            }
        }
        private void btn_lammoikh_Click(object sender, EventArgs e)
        {
            txt_makh.Enabled = true;
            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_sdtkh.Text = "";
            txt_diachikh.Text = "";
            txt_emailkh.Text = "";
        }

        public bool checkDataOrder()
        {

            if (string.IsNullOrEmpty(txt_madh.Text))
            {
                MessageBox.Show("Chưa nhập mã đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_madh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_maspdh.Text))
            {
                MessageBox.Show("Chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_maspdh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_giaspdh.Text))
            {
                MessageBox.Show("Chưa nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_giaspdh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_soluongdh.Text))
            {
                MessageBox.Show("Chưa nhập số lượng đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soluongdh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_thanhtien.Text))
            {
                MessageBox.Show("Chưa nhập thành tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_thanhtien.Focus();
                return false;
            }
            return true;

        }

        private void btn_taodh_Click(object sender, EventArgs e)
        {
            if (checkDataOrder())
            {
                Order ord = new Order();
                ord.OrderID = txt_maspdh.Text;
                ord.ProductID = txt_maspdh.Text;
                ord.CustomerID = txt_makhdh.Text;
                ord.OrderQuantity = int.Parse(txt_soluongdh.Text);
                ord.Price = decimal.Parse(txt_soluongdh.Text);
                ord.Total = int.Parse(txt_thanhtien.Text);

                if (orderCtr.addOrd(ord))
                {
                    showAllOrd();
                }
                else
                {
                    MessageBox.Show("Không thêm được đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_huydh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa đơn hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Order ord = new Order();
                ord.OrderID = txt_maspdh.Text;
                if (orderCtr.deleteOrd(ord))
                {
                    showAllOrd();
                    txt_madh.Text = "";
                    txt_maspdh.Text = "";
                    txt_makhdh.Text = "";
                    txt_giaspdh.Text = "";
                    txt_thanhtien.Text = "";
                    txt_soluongdh.Text = "";
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_dsdh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madh.Enabled = false;
            int index = e.RowIndex;
            
            txt_madh.Text = dgv_dsdh.Rows[index].Cells["OrderID"].Value.ToString();
            txt_maspdh.Text = dgv_dsdh.Rows[index].Cells["ProductID"].Value.ToString();
            txt_makhdh.Text = dgv_dsdh.Rows[index].Cells["CustomerID"].Value.ToString();
            txt_giaspdh.Text = dgv_dsdh.Rows[index].Cells["Price"].Value.ToString();
            txt_soluongdh.Text = dgv_dsdh.Rows[index].Cells["OrderQuantity"].Value.ToString();
            txt_thanhtien.Text = dgv_dsdh.Rows[index].Cells["Total"].Value.ToString();
        }

        private void btn_lammoidh_Click(object sender, EventArgs e)
        {
            txt_madh.Enabled = true;
            txt_madh.Text = "";
            txt_maspdh.Text = "";
            txt_makhdh.Text = "";
            txt_giaspdh.Text = "";
            txt_thanhtien.Text = "";
            txt_soluongdh.Text = "";
        }


        private void btn_xemttkh_Click(object sender, EventArgs e)
        {
              

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = txt_timdh.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = orderCtr.findOrder(value);
                dgv_dsdh.DataSource = dt;
            }
            else
            {
                showAllOrd();
            }
        }

        private void btn_thoatdh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_thoatkh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_thoatsp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


 using System.Data;
 namespace IntroADO_NET{
    public partial class frmMaintainBook : Form {
        //Khai bao doi tuong de thao tac du lieu
        BookManager bm = new BookManager();
        //Khai bao doi tuong DataTable luu du lieu doc duoc tu database
        DataTable dtBook;
     
        public frmMaintainBook()
        {
            InitializeComponent();
        }             
        //xu ly nut Refresh
        private void btnLoad_Click(object sender, EventArgs e){
            getAllBooks();           
        }
        //Phuong thuc doc du lieu bang Book
        private void getAllBooks(){
            //lay du lieu tu bang Book
            dtBook = bm.getBooks();
            //Xoa rang buoc du lieu tren cac TextBoxes de Binding lai lan sau
            txtBookID.DataBindings.Clear();
            txtBookTitle.DataBindings.Clear();
            txtBookPrice.DataBindings.Clear();
            txtBookQuantity.DataBindings.Clear();
            //Rang buoc du lieu tren cac Textboxes
            txtBookID.DataBindings.Add("Text", dtBook, "BookID");
            txtBookTitle.DataBindings.Add("Text", dtBook, "BookTitle");
            txtBookPrice.DataBindings.Add("Text", dtBook, "BookPrice");
            txtBookQuantity.DataBindings.Add("Text", dtBook, "BookQuantity");
            //Rang buoc du lieu cho GridView
            dgvBookList.DataSource = dtBook;
            //Tinh tong so luong sach
            lbTotalQuantity.Text = "TotalQuantity :" + 
                        dtBook.Compute("SUM(BookQuantity)", string.Empty);
        }
        //Xu ly su kien cho nut Add
        private void btnAddNew_Click(object sender, EventArgs e){
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            float Price = float.Parse(txtBookPrice.Text);
            int Quantity = int.Parse(txtBookQuantity.Text);
            Book book = new Book{
                BookID = ID,
                BookTitle = Title,
                BookPrice = Price,
                BookQuantity = Quantity
            };
            //goi phuong thuc cap nhat
            bool r = bm.addNewBook(book);
            string s = (r == true ? "successful" : "fail");
            MessageBox.Show("Add " + s);
            //Refresh du lieu
            getAllBooks();

        }
        //Xu ly su kien cho nut Update
        private void btnUpdate_Click(object sender, EventArgs e){
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            float Price = float.Parse(txtBookPrice.Text);
            int Quantity = int.Parse(txtBookQuantity.Text);
            Book book = new Book { BookID = ID, BookTitle = Title, 
                BookPrice = Price, BookQuantity = Quantity };
            //goi phuong thuc cap nhat
            bool r = bm.updateBook(book);           
            string s = (r==true?"successful":"fail");
            MessageBox.Show("Update " + s);
            //Refresh du lieu
            getAllBooks();
        }       
        //xu ly su kien cho nut Delete
        private void btnDelete_Click(object sender, EventArgs e) {
            int ID = int.Parse(txtBookID.Text);
            //Goi ham xoa Sach
            bool r = bm.deleteBook(ID);
            string s = (r == true ? "successful" : "fail");
            MessageBox.Show("Delete " + s);
            //Refresh du lieu
            getAllBooks();        
        }
        //Loc du lieu theo BookTitle
        private void txtTitleFilter_TextChanged(object sender, EventArgs e){
            DataView dv = dtBook.DefaultView;
            string filter = "BookTitle like '%" + txtTitleFilter.Text + "%'";
            dv.RowFilter = filter;        
            //Hien thi len label
            lbTotalQuantity.Text = "TotalQuantity :" + 
                            dtBook.Compute("SUM(BookQuantity)", filter);
        }           
    }//end class
 }//end namespace

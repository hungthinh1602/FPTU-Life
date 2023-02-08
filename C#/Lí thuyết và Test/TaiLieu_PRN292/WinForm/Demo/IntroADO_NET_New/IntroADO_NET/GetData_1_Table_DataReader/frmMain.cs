using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetData_1_Table_DataReader{
    public partial class frmMain : Form {
        public frmMain()
        {
            InitializeComponent();
        }
        public SqlDataReader GetAllBook()
        {
            string strConnection =
                "server=.;database=manager;uid=sa;pwd=123";
            string SQL = "select * from Books";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            //cnn.Close();
            return rd;
        }
        private void btnGetBooks_Click(object sender, EventArgs e){
            //hien thi len ListBox
            List<Book> bookList = new List<Book>();
            int ID;
            string Title;
            SqlDataReader rd = GetAllBook();
            if (rd.HasRows) //kiem tra co du lieu tra ve ?
            {
                while (rd.Read()) {
                    ID = rd.GetInt32(0);
                    Title = rd.GetString(1);                   
                    lstBookName.Items.Add(ID + "," + Title);                    
                    bookList.Add(new Book{ BookID=ID,BookTitle=Title});
                }//ket thuc 
                rd.Close();
            }
            //hien thi tren GridView         
            dgvBooks.DataSource = bookList;
           
        }
    }
    //------------------------------------------------
    public class Book
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
    }
}

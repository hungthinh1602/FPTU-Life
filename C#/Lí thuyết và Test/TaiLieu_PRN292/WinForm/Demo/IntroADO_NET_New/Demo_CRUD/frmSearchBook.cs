using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntroADO_NET
{
    public partial class frmSearchBook : Form
    {
        public frmSearchBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strConnection = "server=.;database=manager;uid=sa;pwd=123";
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = 
                "select BookTitle,BookQuantity,BookPrice, BookID from "
            +" Books where BookTitle like @title";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@title", "%" + txtTitle.Text + "%");
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Book> listBook = new List<Book>(); 
            if (dr.HasRows) {                      
                while (dr.Read()){
                    Book b = new Book();
                    b.BookID = dr.GetInt32(3);
                    b.BookTitle = dr.GetString(0);
                    b.BookQuantity = dr.GetInt32(1);
                    b.BookPrice = dr.GetDouble(2);
                    listBook.Add(b);
                }
                dgvBooks.DataSource = listBook;
                MessageBox.Show("Found "+listBook.Count+" books");
            }
            dr.Close();
            cnn.Close();

        }
    }
}

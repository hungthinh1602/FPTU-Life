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
    public partial class frmMaintainBook : Form
    {
        string strConnection = "server=.;database=Manager;uid=sa;pwd=123;";//Integrated Security=true";
       
        public frmMaintainBook()
        {
            InitializeComponent();
        }       
        #region ADO.NET
        public DataTable GetBooks()
        {
            string SQL = "select * from Books";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            if (cnn.State == ConnectionState.Closed) {
                cnn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtBook = new DataTable();
            da.Fill(dtBook);
            cnn.Close();
            return dtBook;
        }
        public bool AddNewBook(int BookID,string BookTitle,float BookPrice) {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Insert Books values(@ID,@Title,@Price)";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID",BookID);
            cmd.Parameters.AddWithValue("@Title",BookTitle);
            cmd.Parameters.AddWithValue("@Price",BookPrice);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        public bool UpdateBook(int BookID, string BookTitle, float BookPrice)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Update Books set BookTitle=@Title,BookPrice=@Price where BookID=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", BookID);
            cmd.Parameters.AddWithValue("@Title", BookTitle);
            cmd.Parameters.AddWithValue("@Price", BookPrice);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        public bool DeleteBook(int BookID)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "spDeleteBook";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", BookID);         
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        #endregion
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable dtBook = GetBooks();
            dgvBookList.DataSource = dtBook;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            float Price = float.Parse(txtBookPrice.Text);
            if (AddNewBook(ID, Title, Price))
            {
                MessageBox.Show("Save successful");
            }
            else {
                MessageBox.Show("Save fail.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            float Price = float.Parse(txtBookPrice.Text);
            if (UpdateBook(ID, Title, Price))
            {
                MessageBox.Show("Save successful");
            }
            else
            {
                MessageBox.Show("Save fail.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtBookID.Text);
          
            if (DeleteBook(ID))
            {
                MessageBox.Show("Save successful");
            }
            else
            {
                MessageBox.Show("Save fail.");
            }
        }
      
    }
}

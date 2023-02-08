using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;
namespace IntroADO_NET
{
    public partial class frmMaintainBook : Form
    {
        string strConnection;//Integrated Security=true";
       
        public frmMaintainBook()
        {
            InitializeComponent();

            strConnection = ConfigurationManager.ConnectionStrings
                ["ManagerDB"].ConnectionString;
        }
        
        #region ADO.NET
        public DataTable GetBooks(){
            string SQL = "select * from Books";
            SqlConnection cnn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtBook = new DataTable();
            try {
                if (cnn.State == ConnectionState.Closed){
                    cnn.Open();
                }
                da.Fill(dtBook);
            }
            catch (SqlException se){
                MessageBox.Show(se.Message);
            }
            finally{
                cnn.Close();
            }
            return dtBook;
        }
        public bool addNewBook(int BookID,string BookTitle,
            float BookPrice,int BookQuantity) {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL =
                "Insert Books values(@ID,@Title,@Quantity,@Price)";
            //string SQL = "spAddBook";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID",BookID);
            cmd.Parameters.AddWithValue("@Title",BookTitle);
            cmd.Parameters.AddWithValue("@Quantity", BookQuantity);
            cmd.Parameters.AddWithValue("@Price",BookPrice);
            //cmd.CommandType = CommandType.StoredProcedure;
            if (cnn.State == ConnectionState.Closed) {
                cnn.Open();
            }
            int count = cmd.ExecuteNonQuery();
            return (count > 0);
        }
        public bool UpdateBook(int BookID, string BookTitle, float BookPrice, int BookQuantity)
        {
            SqlConnection cnn = new SqlConnection(strConnection);
            string SQL = "Update Books set BookTitle=@Title,BookQuantity =@Quantity,BookPrice=@Price where BookID=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            //cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", BookID);
            cmd.Parameters.AddWithValue("@Title", BookTitle);
            cmd.Parameters.AddWithValue("@Quantity", BookQuantity);
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
            string SQL = "Delete Books where BookID=@ID";
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.Parameters.AddWithValue("@ID", BookID);         
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

            txtBookID.DataBindings.Clear();
            txtBookTitle.DataBindings.Clear();
            txtBookPrice.DataBindings.Clear();
            txtBookQuantity.DataBindings.Clear();

            txtBookID.DataBindings.Add("Text", dtBook, "BookID");
            txtBookTitle.DataBindings.Add("Text", dtBook, "BookTitle");
            txtBookPrice.DataBindings.Add("Text", dtBook, "BookPrice");
            txtBookQuantity.DataBindings.Add("Text", dtBook, "BookQuantity");
            
            dgvBookList.DataSource = dtBook.Copy();
        }
        private void btnAdd_Click(object sender, EventArgs e){
            int ID = int.Parse(txtBookID.Text);
            string Title = txtBookTitle.Text;
            float Price = float.Parse(txtBookPrice.Text);
            int Quantity = int.Parse(txtBookQuantity.Text);
            if (addNewBook(ID, Title, Price,Quantity)){
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
            int Quantity = int.Parse(txtBookQuantity.Text);
            if (UpdateBook(ID, Title, Price,Quantity))
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

        private void frmMaintainBook_Load(object sender, EventArgs e)
        {           
        }

        public void ShowForm()
        {
            frmLogin frm = new frmLogin();
            Application.Run(frm);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread t = new Thread(new ThreadStart(ShowForm));
            t.Start();
            this.Close();
        }
      
    }
}
